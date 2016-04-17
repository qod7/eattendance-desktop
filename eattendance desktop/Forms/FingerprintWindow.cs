using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eattendance_desktop.Forms
{
    public partial class FingerprintWindow : Form
    {
        public bool fpSuccess = false;
        public byte[] fpTmpData = new byte[2000];
        Device device;
        int fpRegisteredCount = 0;

        // device/user paramenters
        zkemkeeper.CZKEMClass azkemkeeper;
        int iMachineNumber;
        int idwErrorCode = 0;
        string sUserID = "999999999";
        string sUserName = "TempUser";
        string sPassword = "0";
        int iPrivilege = 0;
        int iFingerIndex = 1;
        int iTmpLength = 0;
        bool bCanSaveTmp = false;
        bool bEnabled = true;
        int iFlag = 1;

        public FingerprintWindow(Device device)
        {
            InitializeComponent();
            this.device = device;
            if (device != null)
            {
                this.azkemkeeper = device.device;
                this.iMachineNumber = device.deviceNumber;
            }
        }

        private void FingerprintWindow_Load(object sender, EventArgs e)
        {
            // device has to be pre-connected
            if (device == null) this.Close();
            if (!device.isConnected) this.Close();
            // BIRDS EYE VIEW
            // create a temporary user in device
            // get fingerprint for the temp user
            // the fingerprint will be returned by this window
            // finally delete the temporary user
            
            azkemkeeper.CancelOperation();
            // Register on finger event to update progressBar
            azkemkeeper.OnFingerFeature += new zkemkeeper._IZKEMEvents_OnFingerFeatureEventHandler(this.onFingerFeature);
            // If the specified index of user's templates has existed ,delete it first.(SSR_DelUserTmp is also available sometimes)
            azkemkeeper.SSR_DelUserTmpExt(iMachineNumber, sUserID, iFingerIndex);
            if (!azkemkeeper.SSR_SetUserInfo(iMachineNumber, sUserID, sUserName, sPassword, iPrivilege, bEnabled))
            {
                MessageBox.Show("Couldn't get device to receive fingerprint.");
                this.Close();
            }
            if (azkemkeeper.StartEnrollEx(sUserID, iFingerIndex, iFlag))
            {
                bCanSaveTmp = true;
                azkemkeeper.StartIdentify(); // After enrolling templates,you should let the device into the 1:N verification condition
            }
            else
            {
                azkemkeeper.GetLastError(ref idwErrorCode);
                MessageBox.Show("Operation failed, ErrorCode = " + idwErrorCode.ToString(), "Error");
                this.Close();
            }
        }

        private void onFingerFeature(int Score)
        {
            fpRegisteredCount += 1;
            PictureBox fpProgress = (PictureBox)this.Controls[String.Format("fpProgress{0}", fpRegisteredCount)];
            fpProgress.Visible = true;

            if (fpRegisteredCount == 3)
            {
                if (!bCanSaveTmp)
                {
                    MessageBox.Show("Some interferance occurred. Please try again.");
                    this.Close();
                }
                // receive the registered fingerprint
                this.labelInfo.Text = "Receiving new fingerprint. Please Wait...";
                azkemkeeper.EnableDevice(iMachineNumber, false);
                Cursor = Cursors.WaitCursor;
                azkemkeeper.ReadAllTemplate(iMachineNumber);
                while (azkemkeeper.SSR_GetUserInfo(iMachineNumber, sUserID, out sUserName, out sPassword, out iPrivilege, out bEnabled))
                {
                    if (azkemkeeper.GetUserTmpEx(iMachineNumber, sUserID, iFingerIndex, out iFlag, out fpTmpData[0], out iTmpLength))
                    {
                        // data stored in fpTmpData
                        this.fpSuccess = true;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Fetch Error!", "Error");
                    }
                }
                // finally delete the temporary user
                if (!azkemkeeper.SSR_DeleteEnrollData(iMachineNumber, sUserID, 12))
                {
                    // couldn't delete temp user
                    MessageBox.Show("Fingerprint received but temporary user couldn't be deleted.");
                }
                azkemkeeper.RefreshData(iMachineNumber); // the data in the device should be refreshed
                azkemkeeper.EnableDevice(iMachineNumber, true);
                Cursor = Cursors.Default;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.fpSuccess = false;
            this.Close();
        }
    }
}
