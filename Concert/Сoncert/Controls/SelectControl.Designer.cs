namespace Сoncert.Forms
{
    partial class SelectControl
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkedListBoxPlayList = new System.Windows.Forms.CheckedListBox();
            this.groupBoxNew = new System.Windows.Forms.GroupBox();
            this.bnnAdd = new System.Windows.Forms.Button();
            this.txtNewSong = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxPlayList
            // 
            this.checkedListBoxPlayList.CheckOnClick = true;
            this.checkedListBoxPlayList.FormattingEnabled = true;
            this.checkedListBoxPlayList.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxPlayList.Name = "checkedListBoxPlayList";
            this.checkedListBoxPlayList.Size = new System.Drawing.Size(196, 499);
            this.checkedListBoxPlayList.TabIndex = 0;
            // 
            // groupBoxNew
            // 
            this.groupBoxNew.Controls.Add(this.bnnAdd);
            this.groupBoxNew.Controls.Add(this.txtNewSong);
            this.groupBoxNew.Location = new System.Drawing.Point(214, 12);
            this.groupBoxNew.Name = "groupBoxNew";
            this.groupBoxNew.Size = new System.Drawing.Size(288, 82);
            this.groupBoxNew.TabIndex = 1;
            this.groupBoxNew.TabStop = false;
            this.groupBoxNew.Text = "Новая песня";
            // 
            // bnnAdd
            // 
            this.bnnAdd.Location = new System.Drawing.Point(90, 53);
            this.bnnAdd.Name = "bnnAdd";
            this.bnnAdd.Size = new System.Drawing.Size(75, 23);
            this.bnnAdd.TabIndex = 1;
            this.bnnAdd.Text = "Добавить";
            this.bnnAdd.UseVisualStyleBackColor = true;
            this.bnnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtNewSong
            // 
            this.txtNewSong.Location = new System.Drawing.Point(7, 20);
            this.txtNewSong.Name = "txtNewSong";
            this.txtNewSong.Size = new System.Drawing.Size(253, 20);
            this.txtNewSong.TabIndex = 0;
            this.txtNewSong.TextChanged += new System.EventHandler(this.txtNewSong_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(318, 488);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Выбрать";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(399, 488);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отказаться";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SelectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBoxNew);
            this.Controls.Add(this.checkedListBoxPlayList);
            this.Name = "SelectControl";
            this.Size = new System.Drawing.Size(505, 532);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxNew.ResumeLayout(false);
            this.groupBoxNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxPlayList;
        private System.Windows.Forms.GroupBox groupBoxNew;
        private System.Windows.Forms.Button bnnAdd;
        private System.Windows.Forms.TextBox txtNewSong;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

