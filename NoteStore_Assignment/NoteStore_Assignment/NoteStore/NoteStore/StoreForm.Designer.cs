namespace NoteStore
{
    partial class StoreForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtStoreFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStoreInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStoreOutput = new System.Windows.Forms.TextBox();
            this.pnlActionPanel = new System.Windows.Forms.Panel();
            this.btnStoreCreate = new System.Windows.Forms.Button();
            this.btnStoreFolder = new System.Windows.Forms.Button();
            this.btnStoreSaveAs = new System.Windows.Forms.Button();
            this.btnStoreWrite = new System.Windows.Forms.Button();
            this.btnStoreRead = new System.Windows.Forms.Button();
            this.btnStoreLine = new System.Windows.Forms.Button();
            this.btnStoreAll = new System.Windows.Forms.Button();
            this.btnStoreChar = new System.Windows.Forms.Button();
            this.btnStoreAppend = new System.Windows.Forms.Button();
            this.btnStoreDelete = new System.Windows.Forms.Button();
            this.btnStoreClear = new System.Windows.Forms.Button();
            this.pnlActionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(38, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1050, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Name";
            // 
            // txtStoreFile
            // 
            this.txtStoreFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStoreFile.Location = new System.Drawing.Point(38, 166);
            this.txtStoreFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStoreFile.Name = "txtStoreFile";
            this.txtStoreFile.Size = new System.Drawing.Size(1048, 26);
            this.txtStoreFile.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(38, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1050, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Text";
            // 
            // txtStoreInput
            // 
            this.txtStoreInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStoreInput.Location = new System.Drawing.Point(38, 274);
            this.txtStoreInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStoreInput.Multiline = true;
            this.txtStoreInput.Name = "txtStoreInput";
            this.txtStoreInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStoreInput.Size = new System.Drawing.Size(1048, 229);
            this.txtStoreInput.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(38, 531);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1050, 40);
            this.label4.TabIndex = 5;
            this.label4.Text = "File Content / Result";
            // 
            // txtStoreOutput
            // 
            this.txtStoreOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStoreOutput.Location = new System.Drawing.Point(38, 574);
            this.txtStoreOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStoreOutput.Multiline = true;
            this.txtStoreOutput.Name = "txtStoreOutput";
            this.txtStoreOutput.ReadOnly = true;
            this.txtStoreOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStoreOutput.Size = new System.Drawing.Size(1048, 444);
            this.txtStoreOutput.TabIndex = 6;
            // 
            // pnlActionPanel
            // 
            this.pnlActionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActionPanel.Controls.Add(this.btnStoreCreate);
            this.pnlActionPanel.Controls.Add(this.btnStoreFolder);
            this.pnlActionPanel.Controls.Add(this.btnStoreSaveAs);
            this.pnlActionPanel.Controls.Add(this.btnStoreWrite);
            this.pnlActionPanel.Controls.Add(this.btnStoreRead);
            this.pnlActionPanel.Controls.Add(this.btnStoreLine);
            this.pnlActionPanel.Controls.Add(this.btnStoreAll);
            this.pnlActionPanel.Controls.Add(this.btnStoreChar);
            this.pnlActionPanel.Controls.Add(this.btnStoreAppend);
            this.pnlActionPanel.Controls.Add(this.btnStoreDelete);
            this.pnlActionPanel.Controls.Add(this.btnStoreClear);
            this.pnlActionPanel.Location = new System.Drawing.Point(1132, 92);
            this.pnlActionPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlActionPanel.Name = "pnlActionPanel";
            this.pnlActionPanel.Size = new System.Drawing.Size(398, 969);
            this.pnlActionPanel.TabIndex = 7;
            // 
            // btnStoreCreate
            // 
            this.btnStoreCreate.Location = new System.Drawing.Point(22, 34);
            this.btnStoreCreate.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnStoreCreate.Name = "btnStoreCreate";
            this.btnStoreCreate.Size = new System.Drawing.Size(352, 68);
            this.btnStoreCreate.TabIndex = 7;
            this.btnStoreCreate.Text = "Create File";
            this.btnStoreCreate.UseVisualStyleBackColor = true;
            this.btnStoreCreate.Click += new System.EventHandler(this.btnStoreCreate_Click);
            // 
            // btnStoreFolder
            // 
            this.btnStoreFolder.Location = new System.Drawing.Point(22, 117);
            this.btnStoreFolder.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnStoreFolder.Name = "btnStoreFolder";
            this.btnStoreFolder.Size = new System.Drawing.Size(352, 68);
            this.btnStoreFolder.TabIndex = 8;
            this.btnStoreFolder.Text = "Create New File Path";
            this.btnStoreFolder.UseVisualStyleBackColor = true;
            this.btnStoreFolder.Click += new System.EventHandler(this.btnStoreFolder_Click);
            // 
            // btnStoreSaveAs
            // 
            this.btnStoreSaveAs.Location = new System.Drawing.Point(22, 200);
            this.btnStoreSaveAs.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnStoreSaveAs.Name = "btnStoreSaveAs";
            this.btnStoreSaveAs.Size = new System.Drawing.Size(352, 68);
            this.btnStoreSaveAs.TabIndex = 9;
            this.btnStoreSaveAs.Text = "Create New File Name";
            this.btnStoreSaveAs.UseVisualStyleBackColor = true;
            this.btnStoreSaveAs.Click += new System.EventHandler(this.btnStoreSaveAs_Click);
            // 
            // btnStoreWrite
            // 
            this.btnStoreWrite.Location = new System.Drawing.Point(22, 283);
            this.btnStoreWrite.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnStoreWrite.Name = "btnStoreWrite";
            this.btnStoreWrite.Size = new System.Drawing.Size(352, 68);
            this.btnStoreWrite.TabIndex = 10;
            this.btnStoreWrite.Text = "Write File";
            this.btnStoreWrite.UseVisualStyleBackColor = true;
            this.btnStoreWrite.Click += new System.EventHandler(this.btnStoreWrite_Click);
            // 
            // btnStoreRead
            // 
            this.btnStoreRead.Location = new System.Drawing.Point(22, 366);
            this.btnStoreRead.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnStoreRead.Name = "btnStoreRead";
            this.btnStoreRead.Size = new System.Drawing.Size(352, 68);
            this.btnStoreRead.TabIndex = 11;
            this.btnStoreRead.Text = "Read File";
            this.btnStoreRead.UseVisualStyleBackColor = true;
            this.btnStoreRead.Click += new System.EventHandler(this.btnStoreRead_Click);
            // 
            // btnStoreLine
            // 
            this.btnStoreLine.Location = new System.Drawing.Point(22, 449);
            this.btnStoreLine.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnStoreLine.Name = "btnStoreLine";
            this.btnStoreLine.Size = new System.Drawing.Size(352, 68);
            this.btnStoreLine.TabIndex = 12;
            this.btnStoreLine.Text = "Read Using ReadLine()";
            this.btnStoreLine.UseVisualStyleBackColor = true;
            this.btnStoreLine.Click += new System.EventHandler(this.btnStoreLine_Click);
            // 
            // btnStoreAll
            // 
            this.btnStoreAll.Location = new System.Drawing.Point(22, 532);
            this.btnStoreAll.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnStoreAll.Name = "btnStoreAll";
            this.btnStoreAll.Size = new System.Drawing.Size(352, 68);
            this.btnStoreAll.TabIndex = 13;
            this.btnStoreAll.Text = "Read Using ReadAllText()";
            this.btnStoreAll.UseVisualStyleBackColor = true;
            this.btnStoreAll.Click += new System.EventHandler(this.btnStoreAll_Click);
            // 
            // btnStoreChar
            // 
            this.btnStoreChar.Location = new System.Drawing.Point(22, 615);
            this.btnStoreChar.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnStoreChar.Name = "btnStoreChar";
            this.btnStoreChar.Size = new System.Drawing.Size(352, 68);
            this.btnStoreChar.TabIndex = 14;
            this.btnStoreChar.Text = "Read() Function";
            this.btnStoreChar.UseVisualStyleBackColor = true;
            this.btnStoreChar.Click += new System.EventHandler(this.btnStoreChar_Click);
            // 
            // btnStoreAppend
            // 
            this.btnStoreAppend.Location = new System.Drawing.Point(22, 698);
            this.btnStoreAppend.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnStoreAppend.Name = "btnStoreAppend";
            this.btnStoreAppend.Size = new System.Drawing.Size(352, 68);
            this.btnStoreAppend.TabIndex = 15;
            this.btnStoreAppend.Text = "Append File";
            this.btnStoreAppend.UseVisualStyleBackColor = true;
            this.btnStoreAppend.Click += new System.EventHandler(this.btnStoreAppend_Click);
            // 
            // btnStoreDelete
            // 
            this.btnStoreDelete.Location = new System.Drawing.Point(22, 782);
            this.btnStoreDelete.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnStoreDelete.Name = "btnStoreDelete";
            this.btnStoreDelete.Size = new System.Drawing.Size(352, 68);
            this.btnStoreDelete.TabIndex = 16;
            this.btnStoreDelete.Text = "Delete File";
            this.btnStoreDelete.UseVisualStyleBackColor = true;
            this.btnStoreDelete.Click += new System.EventHandler(this.btnStoreDelete_Click);
            // 
            // btnStoreClear
            // 
            this.btnStoreClear.Location = new System.Drawing.Point(22, 865);
            this.btnStoreClear.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnStoreClear.Name = "btnStoreClear";
            this.btnStoreClear.Size = new System.Drawing.Size(352, 68);
            this.btnStoreClear.TabIndex = 17;
            this.btnStoreClear.Text = "Clear";
            this.btnStoreClear.UseVisualStyleBackColor = true;
            this.btnStoreClear.Click += new System.EventHandler(this.btnStoreClear_Click);
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 1050);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStoreFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStoreInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStoreOutput);
            this.Controls.Add(this.pnlActionPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1399, 954);
            this.Name = "StoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteStore - Simple File Manager";
            this.pnlActionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStoreFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStoreInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStoreOutput;
        private System.Windows.Forms.Panel pnlActionPanel;
        private System.Windows.Forms.Button btnStoreCreate;
        private System.Windows.Forms.Button btnStoreFolder;
        private System.Windows.Forms.Button btnStoreSaveAs;
        private System.Windows.Forms.Button btnStoreWrite;
        private System.Windows.Forms.Button btnStoreRead;
        private System.Windows.Forms.Button btnStoreLine;
        private System.Windows.Forms.Button btnStoreAll;
        private System.Windows.Forms.Button btnStoreChar;
        private System.Windows.Forms.Button btnStoreAppend;
        private System.Windows.Forms.Button btnStoreDelete;
        private System.Windows.Forms.Button btnStoreClear;
    }
}
