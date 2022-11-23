
namespace BasicFacebookFeatures.SubForms
{
    partial class FormGroups
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelGroupDetails = new System.Windows.Forms.Panel();
            this.flowLayoutPanelGroups = new System.Windows.Forms.FlowLayoutPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.panelGroupDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGroupDetails
            // 
            this.panelGroupDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelGroupDetails.Controls.Add(this.labelName);
            this.panelGroupDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGroupDetails.Location = new System.Drawing.Point(473, 0);
            this.panelGroupDetails.Name = "panelGroupDetails";
            this.panelGroupDetails.Size = new System.Drawing.Size(327, 450);
            this.panelGroupDetails.TabIndex = 0;
            // 
            // flowLayoutPanelGroups
            // 
            this.flowLayoutPanelGroups.AutoScroll = true;
            this.flowLayoutPanelGroups.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelGroups.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelGroups.Name = "flowLayoutPanelGroups";
            this.flowLayoutPanelGroups.Size = new System.Drawing.Size(473, 450);
            this.flowLayoutPanelGroups.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelName.Location = new System.Drawing.Point(6, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(137, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Group name:";
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanelGroups);
            this.Controls.Add(this.panelGroupDetails);
            this.Name = "FormGroups";
            this.Text = "FormGroups";
            this.panelGroupDetails.ResumeLayout(false);
            this.panelGroupDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGroupDetails;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGroups;
        private System.Windows.Forms.Label labelName;
    }
}