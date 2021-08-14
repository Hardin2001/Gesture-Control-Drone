using Microsoft.Win32.SafeHandles;
using System.Globalization;
using System.Runtime.InteropServices; 
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GenericHid
{
    internal class FrmMain 
        
        : System.Windows.Forms.Form 
    {         
        #region '"Windows Form Designer generated code "' 
        public FrmMain() : base() 
        {   
            
            // This call is required by the Windows Form Designer.
            InitializeComponent(); 
        } 
        // Form overrides dispose to clean up the component list.
        protected override void Dispose( bool Disposing ) 
        { 
            if ( Disposing ) 
            { 
                if ( !( components == null ) ) 
                { 
                    components.Dispose(); 
                } 
            } 
            base.Dispose( Disposing ); 
        } 
        
        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components; 
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.        
        private HScrollBar hScrollBar1;
        private HScrollBar hScrollBar2;
        private HScrollBar hScrollBar3;
        private HScrollBar hScrollBar4;
        private HScrollBar hScrollBar5;
        private HScrollBar hScrollBar6;
        private HScrollBar hScrollBar7;
        private HScrollBar hScrollBar8;
        private HScrollBar hScrollBar9;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Timer timer1; 
       
        [ System.Diagnostics.DebuggerStepThrough() ]
        private void InitializeComponent() 
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar4 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar5 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar6 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar7 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar8 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar9 = new System.Windows.Forms.HScrollBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(53, 18);
            this.hScrollBar1.Maximum = 255;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(335, 16);
            this.hScrollBar1.TabIndex = 12;
            this.hScrollBar1.Value = 150;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.LargeChange = 1;
            this.hScrollBar2.Location = new System.Drawing.Point(53, 44);
            this.hScrollBar2.Maximum = 255;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(335, 16);
            this.hScrollBar2.TabIndex = 13;
            this.hScrollBar2.Value = 150;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.LargeChange = 1;
            this.hScrollBar3.Location = new System.Drawing.Point(53, 70);
            this.hScrollBar3.Maximum = 255;
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(335, 16);
            this.hScrollBar3.TabIndex = 14;
            this.hScrollBar3.Value = 150;
            this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar3_Scroll);
            // 
            // hScrollBar4
            // 
            this.hScrollBar4.LargeChange = 1;
            this.hScrollBar4.Location = new System.Drawing.Point(53, 96);
            this.hScrollBar4.Maximum = 255;
            this.hScrollBar4.Name = "hScrollBar4";
            this.hScrollBar4.Size = new System.Drawing.Size(335, 16);
            this.hScrollBar4.TabIndex = 15;
            this.hScrollBar4.Value = 150;
            this.hScrollBar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar4_Scroll);
            // 
            // hScrollBar5
            // 
            this.hScrollBar5.LargeChange = 1;
            this.hScrollBar5.Location = new System.Drawing.Point(53, 122);
            this.hScrollBar5.Maximum = 255;
            this.hScrollBar5.Name = "hScrollBar5";
            this.hScrollBar5.Size = new System.Drawing.Size(335, 16);
            this.hScrollBar5.TabIndex = 16;
            this.hScrollBar5.Value = 150;
            this.hScrollBar5.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar5_Scroll);
            // 
            // hScrollBar6
            // 
            this.hScrollBar6.LargeChange = 1;
            this.hScrollBar6.Location = new System.Drawing.Point(53, 148);
            this.hScrollBar6.Maximum = 255;
            this.hScrollBar6.Name = "hScrollBar6";
            this.hScrollBar6.Size = new System.Drawing.Size(335, 16);
            this.hScrollBar6.TabIndex = 17;
            this.hScrollBar6.Value = 150;
            this.hScrollBar6.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar6_Scroll);
            // 
            // hScrollBar7
            // 
            this.hScrollBar7.LargeChange = 1;
            this.hScrollBar7.Location = new System.Drawing.Point(53, 174);
            this.hScrollBar7.Maximum = 255;
            this.hScrollBar7.Name = "hScrollBar7";
            this.hScrollBar7.Size = new System.Drawing.Size(335, 16);
            this.hScrollBar7.TabIndex = 18;
            this.hScrollBar7.Value = 150;
            this.hScrollBar7.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar7_Scroll);
            // 
            // hScrollBar8
            // 
            this.hScrollBar8.LargeChange = 1;
            this.hScrollBar8.Location = new System.Drawing.Point(53, 200);
            this.hScrollBar8.Maximum = 255;
            this.hScrollBar8.Name = "hScrollBar8";
            this.hScrollBar8.Size = new System.Drawing.Size(335, 16);
            this.hScrollBar8.TabIndex = 19;
            this.hScrollBar8.Value = 150;
            this.hScrollBar8.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar8_Scroll);
            // 
            // hScrollBar9
            // 
            this.hScrollBar9.LargeChange = 1;
            this.hScrollBar9.Location = new System.Drawing.Point(53, 226);
            this.hScrollBar9.Maximum = 255;
            this.hScrollBar9.Name = "hScrollBar9";
            this.hScrollBar9.Size = new System.Drawing.Size(335, 16);
            this.hScrollBar9.TabIndex = 20;
            this.hScrollBar9.Value = 150;
            this.hScrollBar9.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar9_Scroll);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "CH1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 14);
            this.label2.TabIndex = 22;
            this.label2.Text = "CH2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 14);
            this.label3.TabIndex = 23;
            this.label3.Text = "CH3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 14);
            this.label4.TabIndex = 24;
            this.label4.Text = "CH4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 14);
            this.label5.TabIndex = 25;
            this.label5.Text = "CH5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 14);
            this.label6.TabIndex = 26;
            this.label6.Text = "CH6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 14);
            this.label7.TabIndex = 27;
            this.label7.Text = "CH7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 14);
            this.label8.TabIndex = 28;
            this.label8.Text = "CH8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 14);
            this.label9.TabIndex = 29;
            this.label9.Text = "CH9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(411, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 14);
            this.label10.TabIndex = 38;
            this.label10.Text = "150";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(411, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 14);
            this.label11.TabIndex = 37;
            this.label11.Text = "150";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(411, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 14);
            this.label12.TabIndex = 36;
            this.label12.Text = "150";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(411, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 14);
            this.label13.TabIndex = 35;
            this.label13.Text = "150";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(411, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 14);
            this.label14.TabIndex = 34;
            this.label14.Text = "150";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(411, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 14);
            this.label15.TabIndex = 33;
            this.label15.Text = "150";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(411, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 14);
            this.label16.TabIndex = 32;
            this.label16.Text = "150";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(411, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 14);
            this.label17.TabIndex = 31;
            this.label17.Text = "150";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(411, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 14);
            this.label18.TabIndex = 30;
            this.label18.Text = "150";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(242, 259);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 14);
            this.label22.TabIndex = 42;
            this.label22.Text = "Not Connected";
            // 
            // label21
            // 
            this.label21.Image = ((System.Drawing.Image)(resources.GetObject("label21.Image")));
            this.label21.Location = new System.Drawing.Point(217, 257);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 16);
            this.label21.TabIndex = 41;
            // 
            // label20
            // 
            this.label20.Image = ((System.Drawing.Image)(resources.GetObject("label20.Image")));
            this.label20.Location = new System.Drawing.Point(217, 257);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 16);
            this.label20.TabIndex = 40;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(142, 259);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 14);
            this.label19.TabIndex = 39;
            this.label19.Text = "PCTx Status:";
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(454, 284);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hScrollBar9);
            this.Controls.Add(this.hScrollBar8);
            this.Controls.Add(this.hScrollBar7);
            this.Controls.Add(this.hScrollBar6);
            this.Controls.Add(this.hScrollBar5);
            this.Controls.Add(this.hScrollBar4);
            this.Controls.Add(this.hScrollBar3);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.hScrollBar1);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(21, 28);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Endurance R/C - PCTx C# Sample";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Closed += new System.EventHandler(this.frmMain_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }         
        #endregion 
        
        private IntPtr deviceNotificationHandle; 
        private Boolean exclusiveAccess; 
        private SafeFileHandle hidHandle; 
        private String hidUsage; 
        private Boolean myDeviceDetected; 
        private String myDevicePathName; 
        private SafeFileHandle readHandle; 
        private SafeFileHandle writeHandle; 
        
        private Debugging MyDebugging = new Debugging(); //  For viewing results of API calls via Debug.Write.
        private DeviceManagement MyDeviceManagement = new DeviceManagement(); 
        private Hid MyHid = new Hid(); 
        
        internal FrmMain FrmMy; 
        
        ///  <summary>
        ///  Define a class of delegates that point to the Hid.ReportIn.Read function.
        ///  The delegate has the same parameters as Hid.ReportIn.Read.
        ///  Used for asynchronous reads from the device.       
        ///  </summary>
        
        private delegate void ReadInputReportDelegate( SafeFileHandle hidHandle, SafeFileHandle readHandle, SafeFileHandle writeHandle, ref Boolean myDeviceDetected, ref Byte[] readBuffer, ref Boolean success );
        
        //  This delegate has the same parameters as AccessForm.
        //  Used in accessing the application's form from a different thread.
        
        private delegate void MarshalToForm( String action, String textToAdd );
        
        ///  <summary>
        ///  Called when a WM_DEVICECHANGE message has arrived,
        ///  indicating that a device has been attached or removed.
        ///  </summary>
        ///  
        ///  <param name="m"> a message with information about the device </param>
        
        internal void OnDeviceChange( Message m ) 
        {             
            //Debug.WriteLine( "WM_DEVICECHANGE" ); 
            
            try 
            {
                if ((m.WParam.ToInt32() == DeviceManagement.DBT_DEVICEARRIVAL)) 
                { 
                    
                    //  If WParam contains DBT_DEVICEARRIVAL, a device has been attached.
                    
                    //Debug.WriteLine( "A device has been attached." ); 
                    
                    //  Find out if it's the device we're communicating with.
                    
                    if ( MyDeviceManagement.DeviceNameMatch( m, myDevicePathName ) ) 
                    { 
                        //lstResults.Items.Add( "My device attached." ); 
                    } 
                    
                }
                else if ((m.WParam.ToInt32() == DeviceManagement.DBT_DEVICEREMOVECOMPLETE)) 
                { 
                    
                    //  If WParam contains DBT_DEVICEREMOVAL, a device has been removed.
                    
                    //Debug.WriteLine( "A device has been removed." ); 
                    
                    //  Find out if it's the device we're communicating with.
                    
                    if ( MyDeviceManagement.DeviceNameMatch( m, myDevicePathName ) ) 
                    { 
                        
                        //lstResults.Items.Add( "My device removed." ); 
                        
                        //  Set MyDeviceDetected False so on the next data-transfer attempt,
                        //  FindTheHid() will be called to look for the device 
                        //  and get a new handle.
                        
                        FrmMy.myDeviceDetected = false; 
                    } 
                }                 
                //ScrollToBottomOfListBox();                 
            } 
            catch ( Exception ex ) 
            { 
//                DisplayException( this.Name, ex ); 
//                throw ; 
            } 
        }         
        
        ///  <summary>
        ///  Uses a series of API calls to locate a HID-class device
        ///  by its Vendor ID and Product ID.
        ///  </summary>
        ///          
        ///  <returns>
        ///   True if the device is detected, False if not detected.
        ///  </returns>
        
        private Boolean FindTheHid() 
        {             
            Boolean deviceFound = false; 
            String[] devicePathName = new String[ 128 ];
            String functionName = "";
            Guid hidGuid = Guid.Empty; 
            Int32 memberIndex = 0;
            Int32 myProductID = 0x1299;
            Int32 myVendorID = 0x0925; 
            Boolean success = false;            
            
            try 
            { 
                myDeviceDetected = false; 
 
                Hid.HidD_GetHidGuid( ref hidGuid );

                functionName = "GetHidGuid"; 
                //Debug.WriteLine( MyDebugging.ResultOfAPICall( functionName ) ); 
                //Debug.WriteLine( "  GUID for system HIDs: " + hidGuid.ToString() ); 
                
                //  Fill an array with the device path names of all attached HIDs.
                
                deviceFound = MyDeviceManagement.FindDeviceFromGuid( hidGuid, ref devicePathName ); 
                
                //  If there is at least one HID, attempt to read the Vendor ID and Product ID
                //  of each device until there is a match or all devices have been examined.
                
                if ( deviceFound ) 
                {                     
                    memberIndex = 0; 
                    
                    do 
                    { 
                        hidHandle = FileIO.CreateFile(devicePathName[memberIndex], 0, FileIO.FILE_SHARE_READ | FileIO.FILE_SHARE_WRITE, IntPtr.Zero, FileIO.OPEN_EXISTING, 0, 0);

                        functionName = "CreateFile"; 
                        //Debug.WriteLine( MyDebugging.ResultOfAPICall( functionName ) ); 
                        //Debug.WriteLine( "  Returned handle: " + hidHandle.ToString() ); 
                        
                        if (!hidHandle.IsInvalid)  
                        {                             
                            
                            MyHid.DeviceAttributes.Size = Marshal.SizeOf( MyHid.DeviceAttributes ); 

                            success = Hid.HidD_GetAttributes(hidHandle, ref MyHid.DeviceAttributes); 
                            
                            if ( success ) 
                            {                                
                                //Debug.WriteLine( "  HIDD_ATTRIBUTES structure filled without error." ); 
                                //Debug.WriteLine( "  Structure size: " + MyHid.DeviceAttributes.Size );                                                                                               
                                //Debug.WriteLine("  Vendor ID: " + Convert.ToString(MyHid.DeviceAttributes.VendorID, 16));                               
                                //Debug.WriteLine("  Product ID: " + Convert.ToString(MyHid.DeviceAttributes.ProductID, 16));                               
                                //Debug.WriteLine("  Version Number: " + Convert.ToString(MyHid.DeviceAttributes.VersionNumber, 16)); 
                                
                                //  Find out if the device matches the one we're looking for.
                                
                                if ( ( MyHid.DeviceAttributes.VendorID == myVendorID ) && ( MyHid.DeviceAttributes.ProductID == myProductID ) ) 
                                { 
                                    
                                    //Debug.WriteLine( "  My device detected" ); 
                                    
                                    //  Display the information in form's list box.
                                    
                                    //lstResults.Items.Add( "Device detected:" );                                   
                                    //lstResults.Items.Add("  Vendor ID= " + Convert.ToString(MyHid.DeviceAttributes.VendorID, 16));                                  
                                    //lstResults.Items.Add("  Product ID = " + Convert.ToString(MyHid.DeviceAttributes.ProductID, 16));
                                    
                                    //ScrollToBottomOfListBox(); 
                                    
                                    myDeviceDetected = true; 
                                    
                                    //  Save the DevicePathName for OnDeviceChange().
                                    
                                    myDevicePathName = devicePathName[ memberIndex ]; 
                                } 
                                else 
                                {                                     
                                    //  It's not a match, so close the handle.
                                    
                                    myDeviceDetected = false;                                     
                                    hidHandle.Close();                                     
                                }                                 
                            } 
                            else 
                            { 
                                //  There was a problem in retrieving the information.
                                
                                //Debug.WriteLine( "  Error in filling HIDD_ATTRIBUTES structure." ); 
                                myDeviceDetected = false; 
                                hidHandle.Close(); 
                            }                             
                        } 
                        
                        //  Keep looking until we find the device or there are no devices left to examine.
                        
                        memberIndex = memberIndex + 1;                         
                    } 
                    while (  ! ( ( myDeviceDetected || ( memberIndex == devicePathName.Length ) ) ) );                     
                } 
                
                if ( myDeviceDetected ) 
                {                     
                    //  The device was detected.
                    //  Register to receive notifications if the device is removed or attached.
                    
                    success = MyDeviceManagement.RegisterForDeviceNotifications( myDevicePathName, FrmMy.Handle, hidGuid, ref deviceNotificationHandle ); 
                    
                    //Debug.WriteLine( "RegisterForDeviceNotifications = " + success ); 
                    
                    //  Learn the capabilities of the device.
                    
                    MyHid.Capabilities = MyHid.GetDeviceCapabilities( hidHandle ); 
                    
                    if ( success ) //这边要改的，应该不是不需要鼠标输入
                    {                         
                        //  Find out if the device is a system mouse or keyboard.
                        
                        hidUsage = MyHid.GetHidUsage( MyHid.Capabilities ); 
                        
                        //  Get the Input report buffer size.
                        
                        GetInputReportBufferSize(); 
                        //cmdInputReportBufferSize.Enabled = true; 
                        
                        //  Get handles to use in requesting Input and Output reports.
                        //这个IO这边换掉
                        readHandle = FileIO.CreateFile(myDevicePathName, FileIO.GENERIC_READ, FileIO.FILE_SHARE_READ | FileIO.FILE_SHARE_WRITE, IntPtr.Zero, FileIO.OPEN_EXISTING, FileIO.FILE_FLAG_OVERLAPPED, 0);

                        functionName = "CreateFile, ReadHandle";
                        //Debug.WriteLine(MyDebugging.ResultOfAPICall(functionName)); 
                        //Debug.WriteLine( "  Returned handle: " + readHandle.ToString() ); 
                        
                        if ( readHandle.IsInvalid ) 
                        {                             
                            exclusiveAccess = true; 
                            //lstResults.Items.Add( "The device is a system " + hidUsage + "." ); 
                            //lstResults.Items.Add( "Windows 2000 and Windows XP obtain exclusive access to Input and Output reports for this devices." ); 
                            //lstResults.Items.Add( "Applications can access Feature reports only." ); 
                            //ScrollToBottomOfListBox();                             
                        } 
                        else 
                        {
                            writeHandle = FileIO.CreateFile(myDevicePathName, FileIO.GENERIC_WRITE, FileIO.FILE_SHARE_READ | FileIO.FILE_SHARE_WRITE, IntPtr.Zero, FileIO.OPEN_EXISTING, 0, 0);

                            functionName = "CreateFile, WriteHandle";
                            //Debug.WriteLine(MyDebugging.ResultOfAPICall(functionName)); 
                            //Debug.WriteLine( "  Returned handle: " + writeHandle.ToString() ); 
                            
                            //  Flush any waiting reports in the input buffer. (optional)
                            
                            MyHid.FlushQueue( readHandle );                             
                        } 
                    } 
                }     
    
                return myDeviceDetected;                 
            } 
            catch ( Exception ex ) 
            { 
                //DisplayException( this.Name, ex ); 
                //throw ; 
                return false;
            } 
        }         
        
        ///  <summary>
        ///  In asynchronous ReadFiles, the callback function GetInputReportData
        ///  uses this routine to access the application's form, which runs in 
        ///  a different thread.
        ///  The routine performs various application-specific functions that
        ///  involve accessing the application's form.
        ///  </summary>
        ///  
        ///  <param name="action"> a String that names the action to perform on the form</param>
        ///  <param name="formText"> text that the form displays or the code uses for 
        ///  another purpose. Actions that don't use text ignore this parameter. </param>
        
        private void AccessForm( String action, String formText ) 
        {             
            try 
            { 
                //  Select an action to perform on the form:
                
                switch ( action ) 
                {
                    case "AddItemToListBox":
                        
//                        lstResults.Items.Add( formText ); 
                        
                        break;
                    case "AddItemToTextBox":
                        
                        //txtBytesReceived.SelectedText = formText + "\r\n"; 
                        
                        break;
                    case "EnableCmdOnce":
                        
                        //  If it's a single transfer, re-enable the command button.
                                         
                        break;
                    case "ScrollToBottomOfListBox":
                        
//                        lstResults.SelectedIndex = lstResults.Items.Count - 1; 
                        
                        break;
                    case "TextBoxSelectionStart":
                        
                        //txtBytesReceived.SelectionStart = formText.Length; //System.Runtime.InteropServices.Marshal.SizeOf( formText ); 
                        
                        break;
                    default:
                        
                        break;
                } 
            } 
            catch ( Exception ex ) 
            { 
                //DisplayException( this.Name, ex ); 
                //throw ; 
            }             
        }         
      
   
 
        
        ///  <summary>
        ///  Called if the user changes the Vendor ID or Product ID in the text box.
        ///  </summary>
          
        private void DeviceHasChanged() 
        {             
            try 
            { 
                //  If a device was previously detected, stop receiving notifications about it.
                
                if ( myDeviceDetected ) 
                { 
                    MyDeviceManagement.StopReceivingDeviceNotifications( deviceNotificationHandle ); 
                } 
                
                //  Search for the device the next time FindTheHid is called.
                
                myDeviceDetected = false;                 
            } 
            catch ( Exception ex ) 
            { 
                //DisplayException( this.Name, ex ); 
                //throw ; 
            } 
        }         
   
        
        ///  <summary>
        ///  Sends an Output report, then retrieves an Input report.
        ///  Assumes report ID = 0 for both reports.
        ///  </summary>
        
        private void ExchangeInputAndOutputReports() 
        {             
            String byteValue = null; 
            Int32 count = 0; 
            Byte[] inputReportBuffer = null; 
            Byte[] outputReportBuffer = null; 
            Boolean success = false; 
            
            try 
            { 
                success = false; 
                
                //  Don't attempt to exchange reports if valid handles aren't available
                //  (as for a mouse or keyboard under Windows 2000/XP.)
                
                //if  ( !readHandle.IsInvalid && !writeHandle.IsInvalid )   
                //{                    
                    //  Don't attempt to send an Output report if the HID has no Output report.
                    
                    //if ( MyHid.Capabilities.OutputReportByteLength > 0 ) 
                    //{                         
                        //  Set the size of the Output report buffer.   
					                        
                        outputReportBuffer = new Byte[ MyHid.Capabilities.OutputReportByteLength]; 
                        
                        //  Store the report ID in the first byte of the buffer:
                        
                        outputReportBuffer[0] = 0;
                        //把Convert.ToByte(hScrollBar3.Value)换成想要输入的数值, 现在的90为水平向前，最小是0，最大是255，但是别调到最大，
                        //150 过一点就是能转动的极限
                        outputReportBuffer[1] = Convert.ToByte(hScrollBar1.Value);
                        outputReportBuffer[2] = Convert.ToByte(hScrollBar2.Value);
                        outputReportBuffer[3] = Convert.ToByte(90);
                        outputReportBuffer[4] = Convert.ToByte(hScrollBar4.Value);
                        outputReportBuffer[5] = Convert.ToByte(hScrollBar5.Value);
                        outputReportBuffer[6] = Convert.ToByte(hScrollBar6.Value);
                        outputReportBuffer[7] = Convert.ToByte(hScrollBar7.Value);
                        outputReportBuffer[8] = Convert.ToByte(hScrollBar8.Value);
                        outputReportBuffer[9] = Convert.ToByte(hScrollBar9.Value);
                        
                
                        //Hid.OutputReportViaControlTransfer myOutputReport = new Hid.OutputReportViaControlTransfer(); 
                        Hid.OutputReportViaInterruptTransfer myOutputReport = new Hid.OutputReportViaInterruptTransfer(); 
                        success = myOutputReport.Write( outputReportBuffer, writeHandle );                    
                    //} 
                //}              
            } 
            catch ( Exception ex ) 
            { 
//                DisplayException( this.Name, ex ); 
//                throw ; 
            }             
        }         
        

        
        private void frmMain_Closed( System.Object eventSender, System.EventArgs eventArgs ) 
        {             
            try 
            { 
                Shutdown();                 
            } 
            catch ( Exception ex ) 
            { 
//                DisplayException( this.Name, ex ); 
//                throw ; 
            } 
        }         
        
        ///  <summary>
        ///  Perform startup operations.
        ///  </summary>
        
        private void frmMain_Load( System.Object eventSender, System.EventArgs eventArgs ) 
        {             
            try 
            { 
                FrmMy = this;
                MyHid = new Hid();                
            } 
            catch ( Exception ex ) 
            { 
//                DisplayException( this.Name, ex ); 
//                throw ; 
            }             
        }         
        
        ///  <summary>
        ///  Finds and displays the number of Input buffers
        ///  (the number of Input reports the host will store). 
        ///  </summary>
        
        private void GetInputReportBufferSize() 
        {             
            Int32 numberOfInputBuffers = 0;
            Boolean success;
            
            try 
            { 
                //  Get the number of input buffers.
                
               success =  MyHid.GetNumberOfInputBuffers( hidHandle, ref numberOfInputBuffers ); 
                
                //  Display the result in the text box.
                
                //txtInputReportBufferSize.Text = Convert.ToString( numberOfInputBuffers );                 
            } 
            catch ( Exception ex ) 
            { 
//                DisplayException( this.Name, ex ); 
//                throw ; 
            }             
        }         
        
        ///  <summary>
        ///  Retrieves Input report data and status information.
        ///  This routine is called automatically when myInputReport.Read
        ///  returns. Calls several marshaling routines to access the main form.
        ///  </summary>
        ///  
        ///  <param name="ar"> an object containing status information about 
        ///  the asynchronous operation. </param>
        
        private void GetInputReportData( IAsyncResult ar ) 
        {             
            String byteValue = null; 
            Int32 count = 0; 
            Byte[] inputReportBuffer = null; 
            Boolean success = false; 
            
            try 
            { 
                // Define a delegate using the IAsyncResult object.
                
                ReadInputReportDelegate deleg = ( ( ReadInputReportDelegate )( ar.AsyncState ) ); 
                
                //  Get the IAsyncResult object and the values of other paramaters that the
                //  BeginInvoke method passed ByRef.
                
                deleg.EndInvoke( ref myDeviceDetected, ref inputReportBuffer, ref success, ar ); 
                
                //  Display the received report data in the form's list box.
                
                if ( ( ar.IsCompleted && success ) ) 
                { 
                    
                    MyMarshalToForm( "AddItemToListBox", "An Input report has been read." );                     
                    MyMarshalToForm( "AddItemToListBox", " Input Report ID: " + String.Format( "{0:X2} ", inputReportBuffer[ 0 ] ) );                     
                    MyMarshalToForm( "AddItemToListBox", " Input Report Data:" ); 
                    
                    for ( count=0; count <= inputReportBuffer.Length -1 ; count++ ) 
                    {                         
                        //  Display bytes as 2-character Hex strings.
                        
                        byteValue = String.Format( "{0:X2} ", inputReportBuffer[ count ] ); 
                        
                        MyMarshalToForm( "AddItemToListBox", " " + byteValue ); 
                        //MyMarshalToForm( "TextBoxSelectionStart", txtBytesReceived.Text ); 
                        MyMarshalToForm( "AddItemToTextBox", byteValue );                         
                    }                     
                } 
                else 
                { 
                    MyMarshalToForm( "AddItemToListBox", "The attempt to read an Input report has failed." ); 
                    //Debug.Write( "The attempt to read an Input report has failed" ); 
                } 
                
                MyMarshalToForm( "ScrollToBottomOfListBox", "" ); 
                
                //  Enable requesting another transfer.
                
                MyMarshalToForm( "EnableCmdOnce", "" );                 
            } 
            catch ( Exception ex ) 
            { 
//                DisplayException( this.Name, ex ); 
//                throw ; 
            }             
        }         
        
    
        
        
        
        ///  <summary>
        ///  Enables accessing a form's controls from another thread 
        ///  </summary>
        ///  
        ///  <param name="action"> a String that names the action to perform on the form </param>
        ///  <param name="textToDisplay"> text that the form displays or the code uses for 
        ///  another purpose. Actions that don't use text ignore this parameter.  </param>
        
        private void MyMarshalToForm( String action, String textToDisplay ) 
        {             
            object[] args = { action, textToDisplay }; 
            MarshalToForm MarshalToFormDelegate = null; 
            
            //  The AccessForm routine contains the code that accesses the form.
            
            MarshalToFormDelegate = new MarshalToForm( AccessForm ); 
            
            //  Execute AccessForm, passing the parameters in args.
            
            base.Invoke( MarshalToFormDelegate, args );             
        }         

                


        ///  <summary>
        ///  Perform actions that must execute when the program ends.
        ///  </summary>
        
        private void Shutdown() 
        {             
            try 
            { 
                //  Close open handles to the device.
                
                if ( !( hidHandle == null ) ) 
                { 
                    if ( !( hidHandle.IsInvalid ) ) 
                    { 
                        hidHandle.Close(); 
                    } 
                } 
                
                if ( !( readHandle == null ) ) 
                { 
                    if ( !( readHandle.IsInvalid ) ) 
                    { 
                        readHandle.Close(); 
                    } 
                } 
                
                if ( !( writeHandle == null ) ) 
                { 
                    if ( !( writeHandle.IsInvalid ) ) 
                    { 
                        writeHandle.Close(); 
                    } 
                } 
                
                //  Stop receiving notifications.
                
                MyDeviceManagement.StopReceivingDeviceNotifications( deviceNotificationHandle );                 
            } 
            catch ( Exception ex ) 
            { 
//                DisplayException( this.Name, ex ); 
//                throw ; 
            }             
        } 
                


      
        
        ///  <summary>
        ///  Finalize method.
        ///  </summary>
        
        ~FrmMain() 
        { 
        } 
                
        ///  <summary>
        ///   Overrides WndProc to enable checking for and handling WM_DEVICECHANGE messages.
        ///  </summary>
        ///  
        ///  <param name="m"> a Windows Message </param>
        
        protected override void WndProc( ref Message m ) 
        {            
            try 
            { 
                //  The OnDeviceChange routine processes WM_DEVICECHANGE messages.
                
                if ( m.Msg == DeviceManagement.WM_DEVICECHANGE ) 
                { 
                    OnDeviceChange( m ); 
                } 
                
                //  Let the base form process the message.
                
                base.WndProc( ref m );                 
            } 
            catch ( Exception ex ) 
            { 
//                DisplayException( this.Name, ex ); 
//                throw ; 
            }             
        }         
        
        ///  <summary>
        ///  Provides a central mechanism for exception handling.
        ///  Displays a message box that describes the exception.
        ///  </summary>
        ///  
        ///  <param name="moduleName"> the module where the exception occurred. </param>
        ///  <param name="e"> the exception </param>
        

                
        [STAThread]
        internal static void Main() { Application.Run( new FrmMain() ); }       
        private static FrmMain transDefaultFormFrmMain = null;
        internal static FrmMain TransDefaultFormFrmMain
        { 
        	get
        	{ 
        		if (transDefaultFormFrmMain == null)
        		{
        			transDefaultFormFrmMain = new FrmMain();
        		}
        		return transDefaultFormFrmMain;
        	} 
        }









        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //  If the device hasn't been detected, was removed, or timed out on a previous attempt
                //  to access it, look for the device.

                if ((myDeviceDetected == false))
                {
                    myDeviceDetected = FindTheHid();

                    label21.Visible = false;
                    label22.Text = "Not Connected";
                }

                if ((myDeviceDetected == true))
                {
                    ExchangeInputAndOutputReports();

                    label21.Visible = true;
                    label22.Text = "Connected";
                }
            }
            catch (Exception ex)
            {
                //DisplayException(this.Name, ex);
                //throw;
                label21.Visible = false;
                label22.Text = "Not Connected";
            }  
        }






        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label18.Text = hScrollBar1.Value.ToString();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label17.Text = hScrollBar2.Value.ToString();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            label16.Text = hScrollBar3.Value.ToString();
        }

        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            label15.Text = hScrollBar4.Value.ToString();
        }

        private void hScrollBar5_Scroll(object sender, ScrollEventArgs e)
        {
            label14.Text = hScrollBar5.Value.ToString();
        }

        private void hScrollBar6_Scroll(object sender, ScrollEventArgs e)
        {
            label13.Text = hScrollBar6.Value.ToString();
        }

        private void hScrollBar7_Scroll(object sender, ScrollEventArgs e)
        {
            label12.Text = hScrollBar7.Value.ToString();
        }

        private void hScrollBar8_Scroll(object sender, ScrollEventArgs e)
        {
            label11.Text = hScrollBar8.Value.ToString();
        }

        private void hScrollBar9_Scroll(object sender, ScrollEventArgs e)
        {
            label10.Text = hScrollBar9.Value.ToString();
        } 
    }      
} 
