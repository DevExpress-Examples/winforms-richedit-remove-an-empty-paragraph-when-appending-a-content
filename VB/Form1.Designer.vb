Namespace RichEditEmptyParagraph

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.button1 = New System.Windows.Forms.Button()
            Me.button2 = New System.Windows.Forms.Button()
            Me.button3 = New System.Windows.Forms.Button()
            Me.button4 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.richEditControl1.Location = New System.Drawing.Point(12, 12)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Size = New System.Drawing.Size(1103, 499)
            Me.richEditControl1.TabIndex = 0
            ' 
            ' button1
            ' 
            Me.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.button1.Location = New System.Drawing.Point(344, 517)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(142, 54)
            Me.button1.TabIndex = 1
            Me.button1.Text = "1) Source RTF"
            Me.button1.UseVisualStyleBackColor = True
            AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.button1_Click)
            ' 
            ' button2
            ' 
            Me.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.button2.Location = New System.Drawing.Point(492, 517)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(142, 54)
            Me.button2.TabIndex = 2
            Me.button2.Text = "2) Find&&Replace"
            Me.button2.UseVisualStyleBackColor = True
            AddHandler Me.button2.Click, New System.EventHandler(AddressOf Me.button2_Click)
            ' 
            ' button3
            ' 
            Me.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.button3.Location = New System.Drawing.Point(640, 517)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(142, 54)
            Me.button3.TabIndex = 3
            Me.button3.Text = "3) Append Document Content"
            Me.button3.UseVisualStyleBackColor = True
            AddHandler Me.button3.Click, New System.EventHandler(AddressOf Me.button3_Click)
            ' 
            ' button4
            ' 
            Me.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.button4.Location = New System.Drawing.Point(788, 517)
            Me.button4.Name = "button4"
            Me.button4.Size = New System.Drawing.Size(142, 54)
            Me.button4.TabIndex = 4
            Me.button4.Text = "4) Delete"
            Me.button4.UseVisualStyleBackColor = True
            AddHandler Me.button4.Click, New System.EventHandler(AddressOf Me.button4_Click)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1127, 583)
            Me.Controls.Add(Me.button4)
            Me.Controls.Add(Me.button3)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.richEditControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl

        Private button1 As System.Windows.Forms.Button

        Private button2 As System.Windows.Forms.Button

        Private button3 As System.Windows.Forms.Button

        Private button4 As System.Windows.Forms.Button
    End Class
End Namespace
