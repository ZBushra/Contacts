namespace Contacts
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label contactIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label client_Label;
            System.Windows.Forms.Label lastCallLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contactDBDataSet = new Contacts.ContactDBDataSet();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleTableAdapter = new Contacts.ContactDBDataSetTableAdapters.PeopleTableAdapter();
            this.tableAdapterManager = new Contacts.ContactDBDataSetTableAdapters.TableAdapterManager();
            this.peopleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.peopleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contactIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.client_CheckBox = new System.Windows.Forms.CheckBox();
            this.lastCallDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            contactIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            client_Label = new System.Windows.Forms.Label();
            lastCallLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingNavigator)).BeginInit();
            this.peopleBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactIDLabel
            // 
            contactIDLabel.AutoSize = true;
            contactIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactIDLabel.ForeColor = System.Drawing.Color.Blue;
            contactIDLabel.Location = new System.Drawing.Point(29, 95);
            contactIDLabel.Name = "contactIDLabel";
            contactIDLabel.Size = new System.Drawing.Size(72, 13);
            contactIDLabel.TabIndex = 2;
            contactIDLabel.Text = "Contact ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.Color.Blue;
            nameLabel.Location = new System.Drawing.Point(29, 121);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(43, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // client_Label
            // 
            client_Label.AutoSize = true;
            client_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            client_Label.ForeColor = System.Drawing.Color.Blue;
            client_Label.Location = new System.Drawing.Point(29, 228);
            client_Label.Name = "client_Label";
            client_Label.Size = new System.Drawing.Size(50, 13);
            client_Label.TabIndex = 6;
            client_Label.Text = "Client?:";
            // 
            // lastCallLabel
            // 
            lastCallLabel.AutoSize = true;
            lastCallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastCallLabel.ForeColor = System.Drawing.Color.Blue;
            lastCallLabel.Location = new System.Drawing.Point(29, 257);
            lastCallLabel.Name = "lastCallLabel";
            lastCallLabel.Size = new System.Drawing.Size(60, 13);
            lastCallLabel.TabIndex = 8;
            lastCallLabel.Text = "Last Call:";
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            companyLabel.ForeColor = System.Drawing.Color.Blue;
            companyLabel.Location = new System.Drawing.Point(29, 147);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(62, 13);
            companyLabel.TabIndex = 10;
            companyLabel.Text = "Company:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telephoneLabel.ForeColor = System.Drawing.Color.Blue;
            telephoneLabel.Location = new System.Drawing.Point(29, 173);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(71, 13);
            telephoneLabel.TabIndex = 12;
            telephoneLabel.Text = "Telephone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.Color.Blue;
            emailLabel.Location = new System.Drawing.Point(29, 199);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(41, 13);
            emailLabel.TabIndex = 14;
            emailLabel.Text = "Email:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(207, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contactDBDataSet
            // 
            this.contactDBDataSet.DataSetName = "ContactDBDataSet";
            this.contactDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this.contactDBDataSet;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PeopleTableAdapter = this.peopleTableAdapter;
            this.tableAdapterManager.UpdateOrder = Contacts.ContactDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // peopleBindingNavigator
            // 
            this.peopleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.peopleBindingNavigator.BindingSource = this.peopleBindingSource;
            this.peopleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.peopleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.peopleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.peopleBindingNavigatorSaveItem});
            this.peopleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.peopleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.peopleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.peopleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.peopleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.peopleBindingNavigator.Name = "peopleBindingNavigator";
            this.peopleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.peopleBindingNavigator.Size = new System.Drawing.Size(330, 25);
            this.peopleBindingNavigator.TabIndex = 1;
            this.peopleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // peopleBindingNavigatorSaveItem
            // 
            this.peopleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.peopleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("peopleBindingNavigatorSaveItem.Image")));
            this.peopleBindingNavigatorSaveItem.Name = "peopleBindingNavigatorSaveItem";
            this.peopleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.peopleBindingNavigatorSaveItem.Text = "Save Data";
            this.peopleBindingNavigatorSaveItem.Click += new System.EventHandler(this.peopleBindingNavigatorSaveItem_Click);
            // 
            // contactIDTextBox
            // 
            this.contactIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "ContactID", true));
            this.contactIDTextBox.Location = new System.Drawing.Point(107, 92);
            this.contactIDTextBox.Name = "contactIDTextBox";
            this.contactIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.contactIDTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(107, 118);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // client_CheckBox
            // 
            this.client_CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.peopleBindingSource, "Client?", true));
            this.client_CheckBox.Location = new System.Drawing.Point(107, 223);
            this.client_CheckBox.Name = "client_CheckBox";
            this.client_CheckBox.Size = new System.Drawing.Size(200, 24);
            this.client_CheckBox.TabIndex = 7;
            this.client_CheckBox.UseVisualStyleBackColor = true;
            // 
            // lastCallDateTimePicker
            // 
            this.lastCallDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.peopleBindingSource, "LastCall", true));
            this.lastCallDateTimePicker.Location = new System.Drawing.Point(107, 253);
            this.lastCallDateTimePicker.Name = "lastCallDateTimePicker";
            this.lastCallDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.lastCallDateTimePicker.TabIndex = 9;
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "Company", true));
            this.companyTextBox.Location = new System.Drawing.Point(107, 144);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(200, 20);
            this.companyTextBox.TabIndex = 11;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(107, 170);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.telephoneTextBox.TabIndex = 13;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(107, 196);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 50);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Service Based Database example walkthrough";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(330, 285);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(contactIDLabel);
            this.Controls.Add(this.contactIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(client_Label);
            this.Controls.Add(this.client_CheckBox);
            this.Controls.Add(lastCallLabel);
            this.Controls.Add(this.lastCallDateTimePicker);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.peopleBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Contact List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingNavigator)).EndInit();
            this.peopleBindingNavigator.ResumeLayout(false);
            this.peopleBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ContactDBDataSet contactDBDataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private ContactDBDataSetTableAdapters.PeopleTableAdapter peopleTableAdapter;
        private ContactDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator peopleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton peopleBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox contactIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckBox client_CheckBox;
        private System.Windows.Forms.DateTimePicker lastCallDateTimePicker;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

