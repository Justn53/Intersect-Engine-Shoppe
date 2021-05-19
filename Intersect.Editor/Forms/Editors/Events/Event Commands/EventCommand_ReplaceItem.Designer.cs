using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{
    partial class EventCommandReplaceItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventCommandReplaceItem));
            this.grpReplaceItem = new DarkUI.Controls.DarkGroupBox();
            this.cmbItems = new DarkUI.Controls.DarkComboBox();
            this.lblReplaceWith = new System.Windows.Forms.Label();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.grpReplaceItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpReplaceItem
            // 
            this.grpReplaceItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpReplaceItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpReplaceItem.Controls.Add(this.cmbItems);
            this.grpReplaceItem.Controls.Add(this.lblReplaceWith);
            this.grpReplaceItem.Controls.Add(this.btnCancel);
            this.grpReplaceItem.Controls.Add(this.btnSave);
            this.grpReplaceItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpReplaceItem.Location = new System.Drawing.Point(3, 3);
            this.grpReplaceItem.Name = "grpReplaceItem";
            this.grpReplaceItem.Size = new System.Drawing.Size(253, 100);
            this.grpReplaceItem.TabIndex = 17;
            this.grpReplaceItem.TabStop = false;
            this.grpReplaceItem.Text = "Replace Item:";
            // 
            // cmbItems
            // 
            this.cmbItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbItems.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbItems.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbItems.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbItems.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbItems.ButtonIcon")));
            this.cmbItems.DrawDropdownHoverOutline = false;
            this.cmbItems.DrawFocusRectangle = false;
            this.cmbItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbItems.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Location = new System.Drawing.Point(87, 19);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(160, 21);
            this.cmbItems.TabIndex = 37;
            this.cmbItems.Text = null;
            this.cmbItems.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblReplaceWith
            // 
            this.lblReplaceWith.AutoSize = true;
            this.lblReplaceWith.Location = new System.Drawing.Point(6, 22);
            this.lblReplaceWith.Name = "lblReplaceWith";
            this.lblReplaceWith.Size = new System.Drawing.Size(75, 13);
            this.lblReplaceWith.TabIndex = 36;
            this.lblReplaceWith.Text = "Replace With:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(89, 71);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 71);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EventCommandReplaceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpReplaceItem);
            this.Name = "EventCommandReplaceItem";
            this.Size = new System.Drawing.Size(259, 106);
            this.grpReplaceItem.ResumeLayout(false);
            this.grpReplaceItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpReplaceItem;
        private DarkButton btnCancel;
        private DarkButton btnSave;
        private DarkComboBox cmbItems;
        private System.Windows.Forms.Label lblReplaceWith;
    }
}
