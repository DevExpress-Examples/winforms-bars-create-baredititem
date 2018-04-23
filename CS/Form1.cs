using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CreateEditItem
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.Bar barStandard;
		private DevExpress.XtraBars.Bar barStatus;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.barManager1 = new DevExpress.XtraBars.BarManager();
			this.barStandard = new DevExpress.XtraBars.Bar();
			this.barStatus = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// barManager1
			// 
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
																			 this.barStandard,
																			 this.barStatus});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.MaxItemId = 0;
			this.barManager1.StatusBar = this.barStatus;
			// 
			// barStandard
			// 
			this.barStandard.BarName = "Standard";
			this.barStandard.DockCol = 0;
			this.barStandard.DockRow = 0;
			this.barStandard.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.barStandard.Text = "Standard";
			// 
			// barStatus
			// 
			this.barStatus.BarName = "Status bar";
			this.barStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.barStatus.DockCol = 0;
			this.barStatus.DockRow = 0;
			this.barStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.barStatus.OptionsBar.AllowQuickCustomization = false;
			this.barStatus.OptionsBar.DrawDragBorder = false;
			this.barStatus.OptionsBar.UseWholeRow = true;
			this.barStatus.Text = "Status bar";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(296, 178);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e) {
			DevExpress.XtraBars.BarEditItem item;
			DevExpress.XtraEditors.Repository.RepositoryItemComboBox combo;
			DevExpress.XtraEditors.Repository.RepositoryItemProgressBar progress;

			barManager1.ForceInitialize();

			// create combo
			combo = barManager1.RepositoryItems.Add("ComboBoxEdit") as DevExpress.XtraEditors.Repository.RepositoryItemComboBox;
			combo.Items.Add("Item A");
			combo.Items.Add("Item B");
			item = new DevExpress.XtraBars.BarEditItem(barManager1);
			item.Edit = combo;
			item.EditValue = "[n/a]";
			item.Width = 100;
			barStandard.AddItem(item);

			// create progress
			progress = barManager1.RepositoryItems.Add("ProgressBarControl") as DevExpress.XtraEditors.Repository.RepositoryItemProgressBar;
			item = new DevExpress.XtraBars.BarEditItem(barManager1);
			item.Edit = progress;
			item.EditValue = 26; // 26%
			item.Width = 150;
			barStatus.AddItem(item);
		}
	}
}
