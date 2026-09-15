namespace PhoneBookTeam1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.nameList = new System.Windows.Forms.ListBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.labelTel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameList
            // 
            this.nameList.FormattingEnabled = true;
            this.nameList.ItemHeight = 15;
            this.nameList.Location = new System.Drawing.Point(76, 115);
            this.nameList.Name = "nameList";
            this.nameList.Size = new System.Drawing.Size(250, 274);
            this.nameList.TabIndex = 0;
            this.nameList.SelectedIndexChanged += new System.EventHandler(this.nameList_SelectedIndexChanged);
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(448, 115);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(189, 22);
            this.phoneNumber.TabIndex = 1;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(448, 288);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(189, 22);
            this.searchBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(448, 331);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(85, 35);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "検索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // labelTel
            // 
            this.labelTel.Location = new System.Drawing.Point(445, 84);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(192, 15);
            this.labelTel.TabIndex = 4;
            this.labelTel.Text = "電話番号";
            this.labelTel.DoubleClick += new System.EventHandler(this.labelTel_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "検索";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "名前リスト";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.nameList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nameList;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

