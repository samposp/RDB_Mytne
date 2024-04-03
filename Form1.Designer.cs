namespace RDB_Mytne
{
    partial class Mytne
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loadDataDialog = new OpenFileDialog();
            loadDataBtn = new Button();
            sendSql = new Button();
            sqlQuery = new TextBox();
            sqlResponse = new TextBox();
            SuspendLayout();
            // 
            // loadDataDialog
            // 
            loadDataDialog.Filter = "JSON files (*.json)|*.json";
            loadDataDialog.Title = "Load JSON data";
            // 
            // loadDataBtn
            // 
            loadDataBtn.Location = new Point(41, 34);
            loadDataBtn.Name = "loadDataBtn";
            loadDataBtn.Size = new Size(94, 29);
            loadDataBtn.TabIndex = 0;
            loadDataBtn.Text = "Load data";
            loadDataBtn.UseVisualStyleBackColor = true;
            loadDataBtn.Click += loadDataBtn_Click;
            // 
            // sendSql
            // 
            sendSql.Location = new Point(659, 35);
            sendSql.Name = "sendSql";
            sendSql.Size = new Size(94, 29);
            sendSql.TabIndex = 1;
            sendSql.TabStop = false;
            sendSql.Text = "Send";
            sendSql.UseVisualStyleBackColor = true;
            sendSql.Click += sendSql_Click;
            // 
            // sqlQuery
            // 
            sqlQuery.Location = new Point(286, 35);
            sqlQuery.Multiline = true;
            sqlQuery.Name = "sqlQuery";
            sqlQuery.Size = new Size(367, 112);
            sqlQuery.TabIndex = 2;
            // 
            // sqlResponse
            // 
            sqlResponse.Location = new Point(288, 170);
            sqlResponse.Multiline = true;
            sqlResponse.Name = "sqlResponse";
            sqlResponse.ReadOnly = true;
            sqlResponse.Size = new Size(465, 226);
            sqlResponse.TabIndex = 3;
            // 
            // Mytne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sqlResponse);
            Controls.Add(sqlQuery);
            Controls.Add(sendSql);
            Controls.Add(loadDataBtn);
            Name = "Mytne";
            Text = "Mytne";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog loadDataDialog;
        private Button loadDataBtn;
        private Button sendSql;
        private TextBox sqlQuery;
        private TextBox sqlResponse;
    }
}
