namespace RecipeAssistant
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
            this.button_NewRecipe = new System.Windows.Forms.Button();
            this.textBox_Recipe = new System.Windows.Forms.TextBox();
            this.textBox_Ingredient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_AddIngredient = new System.Windows.Forms.Button();
            this.listBox_Recipe = new System.Windows.Forms.ListBox();
            this.button_RemoveIngredient = new System.Windows.Forms.Button();
            this.textBox_Qty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_LoadRecipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_NewRecipe
            // 
            this.button_NewRecipe.Location = new System.Drawing.Point(313, 12);
            this.button_NewRecipe.Name = "button_NewRecipe";
            this.button_NewRecipe.Size = new System.Drawing.Size(107, 23);
            this.button_NewRecipe.TabIndex = 0;
            this.button_NewRecipe.Text = "New Recipe";
            this.button_NewRecipe.UseVisualStyleBackColor = true;
            this.button_NewRecipe.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Recipe
            // 
            this.textBox_Recipe.Location = new System.Drawing.Point(58, 14);
            this.textBox_Recipe.Name = "textBox_Recipe";
            this.textBox_Recipe.Size = new System.Drawing.Size(249, 20);
            this.textBox_Recipe.TabIndex = 3;
            // 
            // textBox_Ingredient
            // 
            this.textBox_Ingredient.Location = new System.Drawing.Point(14, 68);
            this.textBox_Ingredient.Name = "textBox_Ingredient";
            this.textBox_Ingredient.Size = new System.Drawing.Size(150, 20);
            this.textBox_Ingredient.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Recipe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingredient";
            // 
            // button_AddIngredient
            // 
            this.button_AddIngredient.Location = new System.Drawing.Point(313, 66);
            this.button_AddIngredient.Name = "button_AddIngredient";
            this.button_AddIngredient.Size = new System.Drawing.Size(107, 23);
            this.button_AddIngredient.TabIndex = 7;
            this.button_AddIngredient.Text = "Add Ingredient";
            this.button_AddIngredient.UseVisualStyleBackColor = true;
            this.button_AddIngredient.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox_Recipe
            // 
            this.listBox_Recipe.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Recipe.FormattingEnabled = true;
            this.listBox_Recipe.ItemHeight = 15;
            this.listBox_Recipe.Location = new System.Drawing.Point(14, 110);
            this.listBox_Recipe.MultiColumn = true;
            this.listBox_Recipe.Name = "listBox_Recipe";
            this.listBox_Recipe.Size = new System.Drawing.Size(293, 304);
            this.listBox_Recipe.TabIndex = 8;
            // 
            // button_RemoveIngredient
            // 
            this.button_RemoveIngredient.Location = new System.Drawing.Point(313, 110);
            this.button_RemoveIngredient.Name = "button_RemoveIngredient";
            this.button_RemoveIngredient.Size = new System.Drawing.Size(107, 23);
            this.button_RemoveIngredient.TabIndex = 9;
            this.button_RemoveIngredient.Text = "Remove Ingredient";
            this.button_RemoveIngredient.UseVisualStyleBackColor = true;
            this.button_RemoveIngredient.Click += new System.EventHandler(this.button_RemoveIngredient_Click);
            // 
            // textBox_Qty
            // 
            this.textBox_Qty.Location = new System.Drawing.Point(170, 68);
            this.textBox_Qty.Name = "textBox_Qty";
            this.textBox_Qty.Size = new System.Drawing.Size(137, 20);
            this.textBox_Qty.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Qty";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(313, 391);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(107, 23);
            this.button_Save.TabIndex = 12;
            this.button_Save.Text = "Save Recipe";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_LoadRecipe
            // 
            this.button_LoadRecipe.Location = new System.Drawing.Point(313, 362);
            this.button_LoadRecipe.Name = "button_LoadRecipe";
            this.button_LoadRecipe.Size = new System.Drawing.Size(107, 23);
            this.button_LoadRecipe.TabIndex = 13;
            this.button_LoadRecipe.Text = "Load Recipe";
            this.button_LoadRecipe.UseVisualStyleBackColor = true;
            this.button_LoadRecipe.Click += new System.EventHandler(this.button_LoadRecipe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 427);
            this.Controls.Add(this.button_LoadRecipe);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Qty);
            this.Controls.Add(this.button_RemoveIngredient);
            this.Controls.Add(this.listBox_Recipe);
            this.Controls.Add(this.button_AddIngredient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Ingredient);
            this.Controls.Add(this.textBox_Recipe);
            this.Controls.Add(this.button_NewRecipe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_NewRecipe;
        private System.Windows.Forms.TextBox textBox_Recipe;
        private System.Windows.Forms.TextBox textBox_Ingredient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_AddIngredient;
        private System.Windows.Forms.ListBox listBox_Recipe;
        private System.Windows.Forms.Button button_RemoveIngredient;
        private System.Windows.Forms.TextBox textBox_Qty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_LoadRecipe;
    }
}

