Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Public Class Form1
    Dim t55 As Byte = 5
    Dim t66 As Byte = 5
    Dim t77 As Byte = 5
    Dim t88 As Byte = 5
    Dim t99 As Byte = 5
    Dim t1010 As Byte = 5
    Public filess(10000) As String
    Dim ti As Integer = 0
    Dim bu As Integer = 0
    Dim ti1 As Integer
    Dim ti2 As Integer
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ti1 = 0
        Timer1.Enabled = True
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ti2 = 0
        Timer2.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim check01 As Boolean = False
        Dim check02 As Boolean = False
        Dim str As String = ""
        Dim str2 As String = ""
        Try
            Dim te0 As String = TextBox1.Text
            Dim t10 As Integer = Strings.Left(te0, 1)
            Dim t20 As Integer = Strings.Mid(te0, 2, 1)
            Dim t30 As Integer = Strings.Mid(te0, 3, 1)
            Dim t50 As Integer = Strings.Mid(te0, 4, 1)
            Dim t60 As Integer = Strings.Mid(te0, 5, 1)
            Dim t70 As Integer = Strings.Mid(te0, 6, 1)
            Dim t80 As Integer = Strings.Mid(te0, 7, 1)
            Dim t90 As Integer = Strings.Mid(te0, 8, 1)
            Dim t100 As Integer = Strings.Mid(te0, 9, 1)
            Dim t40 As Integer = Strings.Mid(te0, 9)
            t66 = t60
            t77 = t70
            t55 = t50
            t88 = t80
            t99 = t90
            t1010 = t100
            check02 = True
        Catch
            TextBox2.Text = TextBox2.Text + "請輸入九位數的數字" + ControlChars.CrLf
            With TextBox2
                .SelectionStart = .Text.Length
                .ScrollToCaret()
            End With
            Timer1.Enabled = False
        End Try
        If check02 = True Then
            TextBox1.Enabled = False
            圖片ToolStripMenuItem.Text = "停止"
            If ti1 <= OpenFileDialog1.FileNames.Length - 1 And ti1 >= 0 Then
                check01 = False
                PictureBox1.Image = Image.FromFile(filess(ti1))
                If PictureBox1.Height >= 100 And PictureBox1.Width >= 100 Then check01 = True
                ProgressBar1.Show()
                If check01 = True Then
                    Button3.Enabled = False
                    Button4.Enabled = False
                    PictureBox1.Image = Image.FromFile(filess(ti1))
                    Dim ii9 As Integer
                    str = Mid(filess(ti1), InStr(filess(ti1), "\") + 1)
                    For ii9 = 1 To 99
                        str = Mid(str, InStr(str, "\") + 1)
                        If str2 = str Then Exit For
                        str2 = str
                    Next
                    str = str.Replace(".bmp", "")
                    str = str.Replace(".jpg", "")
                    str = str.Replace(".jpeg", "")
                    str = str.Replace(".gif", "")
                    str = str.Replace(".tif", "")
                    str = str.Replace(".png", "")
                    str = str.Replace(".BMP", "")
                    str = str.Replace(".JPG", "")
                    str = str.Replace(".JPEG", "")
                    str = str.Replace(".GIF", "")
                    str = str.Replace(".TIF", "")
                    str = str.Replace(".PNG", "")
                    TextBox2.Text = TextBox2.Text + "正在加密:" & str + ControlChars.CrLf
                    With TextBox2
                        .SelectionStart = .Text.Length
                        .ScrollToCaret()
                    End With
                    For z = 1 To 2
                        Try
                            Dim te As String = TextBox1.Text
                            Dim t1 As Integer = Strings.Left(te, 1)
                            Dim t2 As Integer = Strings.Mid(te, 2, 1)
                            Dim t3 As Integer = Strings.Mid(te, 3, 1)
                            Dim t5 As Integer = Strings.Mid(te, 4, 1)
                            Dim t6 As Integer = Strings.Mid(te, 5, 1)
                            Dim t7 As Integer = Strings.Mid(te, 6, 1)
                            Dim t8 As Integer = Strings.Mid(te, 7, 1)
                            Dim t9 As Integer = Strings.Mid(te, 8, 1)
                            Dim t110 As Integer = Strings.Mid(te, 9, 1)
                            Dim t4 As Integer = Strings.Mid(te, 9)
                            t66 = t6
                            t77 = t7
                            t55 = t5
                            t88 = t8
                            t99 = t9
                            t1010 = t110
                            Dim rlock(255), glock(255), block(255) As Boolean
                            Dim rm As Integer = 1
                            Dim gm As Integer = 1
                            Dim bm As Integer = 1
                            Dim rm2 As Integer = 0
                            Dim gm2 As Integer = 0
                            Dim bm2 As Integer = 0
                            Dim rm3 As Integer = 0
                            Dim gm3 As Integer = 0
                            Dim bm3 As Integer = 0
                            Dim rmath(255), gmath(255), bmath(255) As Boolean
                            Dim r(255), g(255), b(255) As Byte
                            Dim rs As Integer
                            Dim gs As Integer
                            Dim bs As Integer
                            Dim rrr, ggg, bbb As Integer
                            Dim rgbcheck As Integer = 0
                            Dim rgbcheck2 As Integer = 0
                            Dim rgbcheck3 As Integer = 0
                            Dim pic As Image = PictureBox1.Image
                            If t1 = 0 Then t1 = 10
                            If t2 = 0 Then t2 = 10
                            If t3 = 0 Then t3 = 10
                            rrr = (Math.Abs(pic.Height - pic.Width)) * (t1 ^ 2) * t2 * t3
                            ggg = (Math.Abs(pic.Height - pic.Width)) * (t2 ^ 2) * t1 * t3
                            bbb = (Math.Abs(pic.Height - pic.Width)) * (t3 ^ 2) * t1 * t2
                            rs = rrr Mod 255
                            gs = ggg Mod 255
                            bs = bbb Mod 255
                            Dim rcheck3 As Integer = 256
                            rgbcheck = 0
                            While rgbcheck < 255
                                rm3 += rs
                                While rm3 > 255 Or rm3 < 0
                                    If rm3 > 255 Then
                                        rm3 = 0 + (rm3 - (255))
                                    ElseIf rm3 < 0 Then
                                        rm3 = 0 + (255 - (-rm3))
                                    End If
                                End While
                                If rm3 <= 255 And rm3 >= 0 Then
                                    If rmath(rm3) = False Then
                                        rmath(rm3) = True
                                        r(rgbcheck) = rm3
                                        rgbcheck += 1
                                        rm2 += 1
                                    Else
                                        Dim o As Integer = 255
                                        While rmath(rm3) = True
                                            rm3 += 1
                                            If rm3 > 255 Then rm3 = 0
                                            o -= 1
                                            If o < 1 Then o = 1
                                            If rm3 > 0 And rm3 < 255 Then rcheck3 = rm3
                                        End While
                                        If rmath(rm3) = False Then
                                            rmath(rm3) = True
                                            r(rgbcheck) = rm3
                                            rgbcheck += 1
                                            rm2 += 1
                                        End If
                                    End If
                                End If
                            End While
                            Dim gcheck3 As Integer = 256
                            rgbcheck2 = 0
                            While rgbcheck2 < 255
                                gm3 += gs
                                While gm3 > 255 Or gm3 < 0
                                    If gm3 > 255 Then
                                        gm3 = 0 + (gm3 - (255))
                                    ElseIf gm3 < 0 Then
                                        gm3 = 0 + (255 - (-gm3))
                                    End If
                                End While
                                If gm3 <= 255 And gm3 >= 0 Then
                                    If gmath(gm3) = False Then
                                        gmath(gm3) = True
                                        g(rgbcheck2) = gm3
                                        rgbcheck2 += 1
                                        gm2 += 1
                                    Else
                                        Dim o As Integer = 255
                                        While gmath(gm3) = True
                                            gm3 += 1
                                            If gm3 > 255 Then gm3 = 0
                                            o -= 1
                                            If o < 1 Then o = 1
                                            If gm3 > 0 And gm3 < 255 Then gcheck3 = gm3
                                        End While
                                        If gmath(gm3) = False Then
                                            gmath(gm3) = True
                                            g(rgbcheck2) = gm3
                                            rgbcheck2 += 1
                                            gm2 += 1
                                        End If
                                    End If
                                End If
                            End While
                            Dim bcheck3 As Integer = 256
                            rgbcheck3 = 0
                            While rgbcheck3 < 255
                                bm3 += bs
                                While bm3 > 255 Or bm3 < 0
                                    If bm3 > 255 Then
                                        bm3 = 0 + (bm3 - (255))
                                    ElseIf bm3 < 0 Then
                                        bm3 = 0 + (255 - (-bm3))
                                    End If
                                End While
                                If bm3 <= 255 And bm3 >= 0 Then
                                    If bmath(bm3) = False Then
                                        bmath(bm3) = True
                                        b(rgbcheck3) = bm3
                                        rgbcheck3 += 1
                                        bm2 += 1
                                    Else
                                        Dim o As Integer = 255
                                        While bmath(bm3) = True
                                            bm3 += 1
                                            If bm3 > 255 Then bm3 = 0
                                            o -= 1
                                            If o < 1 Then o = 1
                                            If bm3 > 0 And bm3 < 255 Then bcheck3 = bm3
                                        End While
                                        If bmath(bm3) = False Then
                                            bmath(bm3) = True
                                            b(rgbcheck3) = bm3
                                            rgbcheck3 += 1
                                            bm2 += 1
                                        End If
                                    End If
                                End If
                            End While
                            Dim start_time As Date = Now
                            Dim Width As Integer, Height As Integer
                            Dim mBitmap As Bitmap
                            mBitmap = New Bitmap(PictureBox1.Image)
                            Try
                                Width = mBitmap.Width
                                Height = mBitmap.Height
                                Dim rect As New Rectangle(0, 0, Width, Height)
                                Dim bmpData As BitmapData = mBitmap.LockBits(rect, ImageLockMode.ReadWrite, mBitmap.PixelFormat)
                                Dim ptr As IntPtr = bmpData.Scan0
                                Dim bytes As Integer = bmpData.Stride * Height
                                Dim Bpx As Byte = bmpData.Stride \ mBitmap.Width
                                Dim rgbValues(bytes - 1) As Byte
                                Marshal.Copy(ptr, rgbValues, 0, bytes)
                                For k As Integer = 0 To rgbValues.Length - Bpx Step Bpx
                                    rgbValues(k) = b(rgbValues(k))
                                    rgbValues(k + 1) = g(rgbValues(k + 1))
                                    rgbValues(k + 2) = r(rgbValues(k + 2))
                                    rgbValues(k + 3) = 255
                                Next
                                Marshal.Copy(rgbValues, 0, ptr, bytes)
                                mBitmap.UnlockBits(bmpData)
                                Dim elapsed_time As TimeSpan = Now.Subtract(start_time)
                            Catch ex As SystemException
                                MsgBox(ex.Message, MsgBoxStyle.Critical)
                            End Try
                            PictureBox1.Image = mBitmap
                            Try
                                t66 = t6
                                t77 = t7
                                t55 = t5
                                If t66 = 0 Then t66 = 10
                                If t77 = 0 Then t77 = 10
                                If t55 = 0 Then t55 = 10
                                Dim mBitmap2 As Bitmap
                                mBitmap = New Bitmap(PictureBox1.Image)
                                mBitmap2 = New Bitmap(PictureBox1.Image)
                                Width = mBitmap.Width
                                Height = mBitmap.Height
                                Dim rect As New Rectangle(0, 0, Width, Height)
                                Dim bmpData As BitmapData = mBitmap.LockBits(rect, ImageLockMode.ReadWrite, mBitmap.PixelFormat)
                                Dim ptr As IntPtr = bmpData.Scan0
                                Dim bytes As Integer = bmpData.Stride * Height
                                Dim rect2 As New Rectangle(0, 0, Width, Height)
                                Dim bmpData2 As BitmapData = mBitmap2.LockBits(rect, ImageLockMode.ReadWrite, mBitmap2.PixelFormat)
                                Dim ptr2 As IntPtr = bmpData2.Scan0
                                Dim bytes2 As Integer = bmpData2.Stride * Height
                                Dim Bpx As Byte = bmpData.Stride \ mBitmap.Width
                                Dim Bpx2 As Byte = bmpData2.Stride \ mBitmap2.Width
                                Dim rgbValues(bytes - 1) As Byte
                                Marshal.Copy(ptr, rgbValues, 0, bytes)
                                Dim rgbValues2(bytes - 1) As Byte
                                Marshal.Copy(ptr2, rgbValues2, 0, bytes)
                                Dim wi As Integer = mBitmap.Width
                                Dim he As Integer = mBitmap.Height
                                If wi > he Then
                                    he = mBitmap.Height - t55
                                    For i As Integer = 0 To wi - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(k + i * he * 4) = rgbValues2(he * 4 + i * he * 4 - k)
                                        Next
                                    Next
                                    he = mBitmap.Height - t66
                                    For i As Integer = 0 To wi - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(k + i * he * 4 + 1) = rgbValues2(he * 4 + i * he * 4 - k + 1)
                                        Next
                                    Next
                                    he = mBitmap.Height - t77
                                    For i As Integer = 0 To wi - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(k + i * he * 4 + 2) = rgbValues2(he * 4 + i * he * 4 - k + 2)
                                        Next
                                    Next
                                Else
                                    he = mBitmap.Width - t55
                                    For i As Integer = 0 To mBitmap.Height - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(k + i * he * 4) = rgbValues2(he * 4 + i * he * 4 - k)
                                        Next
                                    Next
                                    he = mBitmap.Width - t66
                                    For i As Integer = 0 To mBitmap.Height - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(k + i * he * 4 + 1) = rgbValues2(he * 4 + i * he * 4 - k + 1)
                                        Next
                                    Next
                                    he = mBitmap.Width - t77
                                    For i As Integer = 0 To mBitmap.Height - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(k + i * he * 4 + 2) = rgbValues2(he * 4 + i * he * 4 - k + 2)
                                        Next
                                    Next
                                End If
                                Marshal.Copy(rgbValues, 0, ptr, bytes) '
                                mBitmap.UnlockBits(bmpData)
                                mBitmap2.UnlockBits(bmpData2)
                                Dim elapsed_time As TimeSpan = Now.Subtract(start_time)
                                PictureBox1.Image = mBitmap
                            Catch ex As SystemException
                                MsgBox(ex.Message, MsgBoxStyle.Critical)
                            End Try
                            Dim bmp As New Bitmap(PictureBox1.Image)
                            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
                            PictureBox1.Image = bmp
                            Try
                                t88 = t8
                                t99 = t9
                                t1010 = t110
                                If t88 = 0 Then t88 = 10
                                If t99 = 0 Then t99 = 10
                                If t1010 = 0 Then t1010 = 10
                                Dim mBitmap2 As Bitmap
                                mBitmap = New Bitmap(PictureBox1.Image)
                                mBitmap2 = New Bitmap(PictureBox1.Image)
                                Width = mBitmap.Width
                                Height = mBitmap.Height
                                Dim rect As New Rectangle(0, 0, Width, Height)
                                Dim bmpData As BitmapData = mBitmap.LockBits(rect, ImageLockMode.ReadWrite, mBitmap.PixelFormat)
                                Dim ptr As IntPtr = bmpData.Scan0
                                Dim bytes As Integer = bmpData.Stride * Height
                                Dim rect2 As New Rectangle(0, 0, Width, Height)
                                Dim bmpData2 As BitmapData = mBitmap2.LockBits(rect, ImageLockMode.ReadWrite, mBitmap2.PixelFormat)
                                Dim ptr2 As IntPtr = bmpData2.Scan0
                                Dim bytes2 As Integer = bmpData2.Stride * Height
                                Dim Bpx As Byte = bmpData.Stride \ mBitmap.Width
                                Dim Bpx2 As Byte = bmpData2.Stride \ mBitmap2.Width
                                Dim rgbValues(bytes - 1) As Byte
                                Marshal.Copy(ptr, rgbValues, 0, bytes)
                                Dim rgbValues2(bytes - 1) As Byte
                                Marshal.Copy(ptr2, rgbValues2, 0, bytes)
                                Dim wi As Integer = mBitmap.Width
                                Dim he As Integer = mBitmap.Height
                                If wi > he Then
                                    he = mBitmap.Height - t88
                                    For i As Integer = 0 To wi - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(k + i * he * 4) = rgbValues2(he * 4 + i * he * 4 - k)
                                        Next
                                    Next
                                    he = mBitmap.Height - t99
                                    For i As Integer = 0 To wi - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(k + i * he * 4 + 1) = rgbValues2(he * 4 + i * he * 4 - k + 1)
                                        Next
                                    Next
                                    he = mBitmap.Height - t1010
                                    For i As Integer = 0 To wi - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(k + i * he * 4 + 2) = rgbValues2(he * 4 + i * he * 4 - k + 2)
                                        Next
                                    Next
                                Else
                                    he = mBitmap.Width - t88
                                    For i As Integer = 0 To mBitmap.Height - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(k + i * he * 4) = rgbValues2(he * 4 + i * he * 4 - k)
                                        Next
                                    Next
                                    he = mBitmap.Width - t99
                                    For i As Integer = 0 To mBitmap.Height - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(k + i * he * 4 + 1) = rgbValues2(he * 4 + i * he * 4 - k + 1)
                                        Next
                                    Next
                                    he = mBitmap.Width - t1010
                                    For i As Integer = 0 To mBitmap.Height - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(k + i * he * 4 + 2) = rgbValues2(he * 4 + i * he * 4 - k + 2)
                                        Next
                                    Next
                                End If
                                Marshal.Copy(rgbValues, 0, ptr, bytes) '
                                mBitmap.UnlockBits(bmpData)
                                mBitmap2.UnlockBits(bmpData2)
                                Dim elapsed_time As TimeSpan = Now.Subtract(start_time)
                                PictureBox1.Image = mBitmap
                            Catch ex As SystemException
                                MsgBox(ex.Message, MsgBoxStyle.Critical)
                            End Try
                            Dim bmp2 As New Bitmap(PictureBox1.Image)
                            bmp2.RotateFlip(RotateFlipType.Rotate270FlipNone)
                            PictureBox1.Image = bmp2
                            System.GC.Collect()
                        Catch ex As SystemException
                            MsgBox(ex.Message, MsgBoxStyle.Critical)
                        End Try
                    Next
                    System.GC.Collect()
                    System.IO.Directory.CreateDirectory(OpenFileDialog1.FileName & "(圖片加密程式加密檔)")
                    PictureBox1.Image.Save(OpenFileDialog1.FileName & "(圖片加密程式加密檔)" & "\" & str & "." & "png")
                Else
                    PictureBox1.Image = Image.FromFile(filess(ti1))
                    Dim ii9 As Integer
                    str = Mid(filess(ti1), InStr(filess(ti1), "\") + 1)
                    For ii9 = 1 To 99
                        str = Mid(str, InStr(str, "\") + 1)
                        If str2 = str Then Exit For
                        str2 = str
                    Next
                    str = str.Replace(".bmp", "")
                    str = str.Replace(".jpg", "")
                    str = str.Replace(".jpeg", "")
                    str = str.Replace(".gif", "")
                    str = str.Replace(".tif", "")
                    str = str.Replace(".png", "")
                    str = str.Replace(".BMP", "")
                    str = str.Replace(".JPG", "")
                    str = str.Replace(".JPEG", "")
                    str = str.Replace(".GIF", "")
                    str = str.Replace(".TIF", "")
                    str = str.Replace(".PNG", "")
                    TextBox2.Text = TextBox2.Text + str & "(加密失敗)" + ControlChars.CrLf
                End If
                ProgressBar1.Value = ti1
                ti1 += 1
            Else
                TextBox1.Enabled = True
                圖片ToolStripMenuItem.Text = "匯入圖片"
                ProgressBar1.Hide()
                ti1 = 0
                TextBox2.Text = TextBox2.Text + "加密完成" + ControlChars.CrLf
                With TextBox2
                    .SelectionStart = .Text.Length
                    .ScrollToCaret()
                End With
                Timer1.Enabled = False
                MsgBox("加密完成")
                Shell("Explorer.exe " & OpenFileDialog1.FileName & "(圖片加密程式加密檔)", vbNormalFocus)
            End If
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim check01 As Boolean = False
        Dim check02 As Boolean = False
        Dim str As String = ""
        Dim str2 As String = ""
        Try
            Dim te0 As String = TextBox1.Text
            Dim t10 As Integer = Strings.Left(te0, 1)
            Dim t20 As Integer = Strings.Mid(te0, 2, 1)
            Dim t30 As Integer = Strings.Mid(te0, 3, 1)
            Dim t50 As Integer = Strings.Mid(te0, 4, 1)
            Dim t60 As Integer = Strings.Mid(te0, 5, 1)
            Dim t70 As Integer = Strings.Mid(te0, 6, 1)
            Dim t80 As Integer = Strings.Mid(te0, 7, 1)
            Dim t90 As Integer = Strings.Mid(te0, 8, 1)
            Dim t100 As Integer = Strings.Mid(te0, 9, 1)
            Dim t40 As Integer = Strings.Mid(te0, 9)
            t66 = t60
            t77 = t70
            t55 = t50
            t88 = t80
            t99 = t90
            t1010 = t100
            check02 = True
        Catch
            TextBox2.Text = TextBox2.Text + "請輸入九位數的數字" + ControlChars.CrLf
            With TextBox2
                .SelectionStart = .Text.Length
                .ScrollToCaret()
            End With
            Timer2.Enabled = False
        End Try
        If check02 = True Then
            TextBox1.Enabled = False
            圖片ToolStripMenuItem.Text = "停止"
            If ti2 <= OpenFileDialog1.FileNames.Length - 1 And ti2 >= 0 Then
                check01 = False
                PictureBox1.Image = Image.FromFile(filess(ti2))
                If PictureBox1.Height >= 100 And PictureBox1.Width >= 100 Then check01 = True
                ProgressBar1.Show()
                If check01 = True Then
                    Button3.Enabled = False
                    Button4.Enabled = False
                    PictureBox1.Image = Image.FromFile(filess(ti2))
                    Dim ii9 As Integer
                    str = Mid(filess(ti2), InStr(filess(ti2), "\") + 1)
                    For ii9 = 1 To 99
                        str = Mid(str, InStr(str, "\") + 1)
                        If str2 = str Then Exit For
                        str2 = str
                    Next
                    str = str.Replace(".bmp", "")
                    str = str.Replace(".jpg", "")
                    str = str.Replace(".jpeg", "")
                    str = str.Replace(".gif", "")
                    str = str.Replace(".tif", "")
                    str = str.Replace(".png", "")
                    str = str.Replace(".BMP", "")
                    str = str.Replace(".JPG", "")
                    str = str.Replace(".JPEG", "")
                    str = str.Replace(".GIF", "")
                    str = str.Replace(".TIF", "")
                    str = str.Replace(".PNG", "")
                    TextBox2.Text = TextBox2.Text + "正在解密:" & str + ControlChars.CrLf
                    With TextBox2
                        .SelectionStart = .Text.Length
                        .ScrollToCaret()
                    End With
                    For z = 1 To 2
                        Try
                            Dim te As String = TextBox1.Text
                            Dim t1 As Integer = Strings.Left(te, 1)
                            Dim t2 As Integer = Strings.Mid(te, 2, 1)
                            Dim t3 As Integer = Strings.Mid(te, 3, 1)
                            Dim t5 As Integer = Strings.Mid(te, 4, 1)
                            Dim t6 As Integer = Strings.Mid(te, 5, 1)
                            Dim t7 As Integer = Strings.Mid(te, 6, 1)
                            Dim t8 As Integer = Strings.Mid(te, 7, 1)
                            Dim t9 As Integer = Strings.Mid(te, 8, 1)
                            Dim t110 As Integer = Strings.Mid(te, 9, 1)
                            Dim t4 As Integer = Strings.Mid(te, 9)
                            t66 = t6
                            t77 = t7
                            t55 = t5
                            t88 = t8
                            t99 = t9
                            t1010 = t110
                            Dim rlock(255), glock(255), block(255) As Boolean
                            Dim rm As Integer = 1
                            Dim gm As Integer = 1
                            Dim bm As Integer = 1
                            Dim rm2 As Integer = 0
                            Dim gm2 As Integer = 0
                            Dim bm2 As Integer = 0
                            Dim rm3 As Integer = 0
                            Dim gm3 As Integer = 0
                            Dim bm3 As Integer = 0
                            Dim rmath(255), gmath(255), bmath(255) As Boolean
                            Dim r(255), g(255), b(255) As Byte
                            Dim rs As Integer
                            Dim gs As Integer
                            Dim bs As Integer
                            Dim rrr, ggg, bbb As Integer
                            Dim rgbcheck As Integer = 0
                            Dim rgbcheck2 As Integer = 0
                            Dim rgbcheck3 As Integer = 0
                            Dim pic As Image = PictureBox1.Image
                            If t1 = 0 Then t1 = 10
                            If t2 = 0 Then t2 = 10
                            If t3 = 0 Then t3 = 10
                            rrr = (Math.Abs(pic.Height - pic.Width)) * (t1 ^ 2) * t2 * t3
                            ggg = (Math.Abs(pic.Height - pic.Width)) * (t2 ^ 2) * t1 * t3
                            bbb = (Math.Abs(pic.Height - pic.Width)) * (t3 ^ 2) * t1 * t2
                            rs = rrr Mod 255
                            gs = ggg Mod 255
                            bs = bbb Mod 255
                            Dim rcheck3 As Integer = 256
                            rgbcheck = 0
                            While rgbcheck < 255
                                rm3 += rs
                                While rm3 > 255 Or rm3 < 0
                                    If rm3 > 255 Then
                                        rm3 = 0 + (rm3 - (255))
                                    ElseIf rm3 < 0 Then
                                        rm3 = 0 + (255 - (-rm3))
                                    End If
                                End While
                                If rm3 <= 255 And rm3 >= 0 Then
                                    If rmath(rm3) = False Then
                                        rmath(rm3) = True
                                        r(rgbcheck) = rm3
                                        rgbcheck += 1
                                        rm2 += 1
                                    Else
                                        Dim o As Integer = 255
                                        While rmath(rm3) = True
                                            rm3 += 1
                                            If rm3 > 255 Then rm3 = 0
                                            o -= 1
                                            If o < 1 Then o = 1
                                            If rm3 > 0 And rm3 < 255 Then rcheck3 = rm3
                                        End While
                                        If rmath(rm3) = False Then
                                            rmath(rm3) = True
                                            r(rgbcheck) = rm3
                                            rgbcheck += 1
                                            rm2 += 1
                                        End If
                                    End If
                                End If
                            End While
                            Dim gcheck3 As Integer = 256
                            rgbcheck2 = 0
                            While rgbcheck2 < 255
                                gm3 += gs
                                While gm3 > 255 Or gm3 < 0
                                    If gm3 > 255 Then
                                        gm3 = 0 + (gm3 - (255))
                                    ElseIf gm3 < 0 Then
                                        gm3 = 0 + (255 - (-gm3))
                                    End If
                                End While
                                If gm3 <= 255 And gm3 >= 0 Then
                                    If gmath(gm3) = False Then
                                        gmath(gm3) = True
                                        g(rgbcheck2) = gm3
                                        rgbcheck2 += 1
                                        gm2 += 1
                                    Else
                                        Dim o As Integer = 255
                                        While gmath(gm3) = True
                                            gm3 += 1
                                            If gm3 > 255 Then gm3 = 0
                                            o -= 1
                                            If o < 1 Then o = 1
                                            If gm3 > 0 And gm3 < 255 Then gcheck3 = gm3
                                        End While
                                        If gmath(gm3) = False Then
                                            gmath(gm3) = True
                                            g(rgbcheck2) = gm3
                                            rgbcheck2 += 1
                                            gm2 += 1
                                        End If
                                    End If
                                End If
                            End While
                            Dim bcheck3 As Integer = 256
                            rgbcheck3 = 0
                            While rgbcheck3 < 255
                                bm3 += bs
                                While bm3 > 255 Or bm3 < 0
                                    If bm3 > 255 Then
                                        bm3 = 0 + (bm3 - (255))
                                    ElseIf bm3 < 0 Then
                                        bm3 = 0 + (255 - (-bm3))
                                    End If
                                End While
                                If bm3 <= 255 And bm3 >= 0 Then
                                    If bmath(bm3) = False Then
                                        bmath(bm3) = True
                                        b(rgbcheck3) = bm3
                                        rgbcheck3 += 1
                                        bm2 += 1
                                    Else
                                        Dim o As Integer = 255
                                        While bmath(bm3) = True
                                            bm3 += 1
                                            If bm3 > 255 Then bm3 = 0
                                            o -= 1
                                            If o < 1 Then o = 1
                                            If bm3 > 0 And bm3 < 255 Then bcheck3 = bm3
                                        End While
                                        If bmath(bm3) = False Then
                                            bmath(bm3) = True
                                            b(rgbcheck3) = bm3
                                            rgbcheck3 += 1
                                            bm2 += 1
                                        End If
                                    End If
                                End If
                            End While
                            Dim rchange1(255) As Byte
                            Dim rchange2(255) As Byte
                            For iii = 0 To 255
                                rchange1(iii) = r(iii)
                                rchange2(rchange1(iii)) = iii
                            Next
                            Dim gchange1(255) As Byte
                            Dim gchange2(255) As Byte
                            For iiii = 0 To 255
                                gchange1(iiii) = g(iiii)
                                gchange2(gchange1(iiii)) = iiii
                            Next
                            Dim bchange1(255) As Byte
                            Dim bchange2(255) As Byte
                            For iiiii = 0 To 255
                                bchange1(iiiii) = b(iiiii)
                                bchange2(bchange1(iiiii)) = iiiii
                            Next
                            Dim start_time As Date = Now
                            Dim Width As Integer, Height As Integer
                            Dim mBitmap As Bitmap
                            mBitmap = New Bitmap(PictureBox1.Image)
                            Try
                                Width = mBitmap.Width
                                Height = mBitmap.Height
                                Dim rect As New Rectangle(0, 0, Width, Height)
                                Dim bmpData As BitmapData = mBitmap.LockBits(rect, ImageLockMode.ReadWrite, mBitmap.PixelFormat)
                                Dim ptr As IntPtr = bmpData.Scan0
                                Dim bytes As Integer = bmpData.Stride * Height
                                Dim Bpx As Byte = bmpData.Stride \ mBitmap.Width
                                Dim rgbValues(bytes - 1) As Byte
                                Marshal.Copy(ptr, rgbValues, 0, bytes)
                                For k As Integer = 0 To rgbValues.Length - Bpx Step Bpx
                                    rgbValues(k) = bchange2(bchange1(bchange2(rgbValues(k))))
                                    rgbValues(k + 1) = gchange2(gchange1(gchange2(rgbValues(k + 1))))
                                    rgbValues(k + 2) = rchange2(rchange1(rchange2(rgbValues(k + 2))))
                                    rgbValues(k + 3) = 255
                                Next
                                Marshal.Copy(rgbValues, 0, ptr, bytes) '
                                mBitmap.UnlockBits(bmpData)
                                Dim elapsed_time As TimeSpan = Now.Subtract(start_time)
                            Catch ex As SystemException
                                MsgBox(ex.Message, MsgBoxStyle.Critical)
                            End Try
                            PictureBox1.Image = mBitmap
                            Dim bmp As New Bitmap(PictureBox1.Image)
                            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
                            PictureBox1.Image = bmp
                            Try
                                t88 = t8
                                t99 = t9
                                t1010 = t110
                                If t88 = 0 Then t88 = 10
                                If t99 = 0 Then t99 = 10
                                If t1010 = 0 Then t1010 = 10
                                Dim mBitmap2 As Bitmap
                                mBitmap = New Bitmap(PictureBox1.Image)
                                mBitmap2 = New Bitmap(PictureBox1.Image)
                                Width = mBitmap.Width
                                Height = mBitmap.Height
                                Dim rect As New Rectangle(0, 0, Width, Height)
                                Dim bmpData As BitmapData = mBitmap.LockBits(rect, ImageLockMode.ReadWrite, mBitmap.PixelFormat)
                                Dim ptr As IntPtr = bmpData.Scan0
                                Dim bytes As Integer = bmpData.Stride * Height
                                Dim rect2 As New Rectangle(0, 0, Width, Height)
                                Dim bmpData2 As BitmapData = mBitmap2.LockBits(rect, ImageLockMode.ReadWrite, mBitmap2.PixelFormat)
                                Dim ptr2 As IntPtr = bmpData2.Scan0
                                Dim bytes2 As Integer = bmpData2.Stride * Height
                                Dim Bpx As Byte = bmpData.Stride \ mBitmap.Width
                                Dim Bpx2 As Byte = bmpData2.Stride \ mBitmap2.Width
                                Dim rgbValues(bytes - 1) As Byte
                                Marshal.Copy(ptr, rgbValues, 0, bytes)
                                Dim rgbValues2(bytes - 1) As Byte
                                Marshal.Copy(ptr2, rgbValues2, 0, bytes)
                                Dim wi As Integer = mBitmap.Width
                                Dim he As Integer = mBitmap.Height
                                If wi > he Then
                                    he = mBitmap.Height - t88
                                    For i As Integer = 0 To wi - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(he * 4 + i * he * 4 - k) = rgbValues2(k + i * he * 4)
                                        Next
                                    Next
                                    he = mBitmap.Height - t99
                                    For i As Integer = 0 To wi - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(he * 4 + i * he * 4 - k + 1) = rgbValues2(k + i * he * 4 + 1)
                                        Next
                                    Next
                                    he = mBitmap.Height - t1010
                                    For i As Integer = 0 To wi - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(he * 4 + i * he * 4 - k + 2) = rgbValues2(k + i * he * 4 + 2)
                                        Next
                                    Next
                                Else
                                    he = mBitmap.Width - t88
                                    For i As Integer = 0 To mBitmap.Height - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(he * 4 + i * he * 4 - k) = rgbValues2(k + i * he * 4)
                                        Next
                                    Next
                                    he = mBitmap.Width - t99
                                    For i As Integer = 0 To mBitmap.Height - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(he * 4 + i * he * 4 - k + 1) = rgbValues2(k + i * he * 4 + 1)
                                        Next
                                    Next
                                    he = mBitmap.Width - t1010
                                    For i As Integer = 0 To mBitmap.Height - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(he * 4 + i * he * 4 - k + 2) = rgbValues2(k + i * he * 4 + 2)
                                        Next
                                    Next
                                End If
                                Marshal.Copy(rgbValues, 0, ptr, bytes) '
                                mBitmap.UnlockBits(bmpData)
                                mBitmap2.UnlockBits(bmpData2)
                                Dim elapsed_time As TimeSpan = Now.Subtract(start_time)
                                PictureBox1.Image = mBitmap
                            Catch
                            End Try
                            Dim bmp2 As New Bitmap(PictureBox1.Image)
                            bmp2.RotateFlip(RotateFlipType.Rotate270FlipNone)
                            PictureBox1.Image = bmp2
                            Try
                                t66 = t6
                                t77 = t7
                                t55 = t5
                                If t66 = 0 Then t66 = 10
                                If t77 = 0 Then t77 = 10
                                If t55 = 0 Then t55 = 10
                                Dim mBitmap2 As Bitmap
                                mBitmap = New Bitmap(PictureBox1.Image)
                                mBitmap2 = New Bitmap(PictureBox1.Image)
                                Width = mBitmap.Width
                                Height = mBitmap.Height
                                Dim rect As New Rectangle(0, 0, Width, Height)
                                Dim bmpData As BitmapData = mBitmap.LockBits(rect, ImageLockMode.ReadWrite, mBitmap.PixelFormat)
                                Dim ptr As IntPtr = bmpData.Scan0
                                Dim bytes As Integer = bmpData.Stride * Height
                                Dim rect2 As New Rectangle(0, 0, Width, Height)
                                Dim bmpData2 As BitmapData = mBitmap2.LockBits(rect, ImageLockMode.ReadWrite, mBitmap2.PixelFormat)
                                Dim ptr2 As IntPtr = bmpData2.Scan0
                                Dim bytes2 As Integer = bmpData2.Stride * Height
                                Dim Bpx As Byte = bmpData.Stride \ mBitmap.Width
                                Dim Bpx2 As Byte = bmpData2.Stride \ mBitmap2.Width
                                Dim rgbValues(bytes - 1) As Byte
                                Marshal.Copy(ptr, rgbValues, 0, bytes)
                                Dim rgbValues2(bytes - 1) As Byte
                                Marshal.Copy(ptr2, rgbValues2, 0, bytes)
                                Dim wi As Integer = mBitmap.Width
                                Dim he As Integer = mBitmap.Height
                                If wi > he Then
                                    he = mBitmap.Height - t55
                                    For i As Integer = 0 To wi - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(he * 4 + i * he * 4 - k) = rgbValues2(k + i * he * 4)
                                        Next
                                    Next
                                    he = mBitmap.Height - t66
                                    For i As Integer = 0 To wi - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(he * 4 + i * he * 4 - k + 1) = rgbValues2(k + i * he * 4 + 1)
                                        Next
                                    Next
                                    he = mBitmap.Height - t77
                                    For i As Integer = 0 To wi - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(he * 4 + i * he * 4 - k + 2) = rgbValues2(k + i * he * 4 + 2)
                                        Next
                                    Next
                                Else
                                    he = mBitmap.Width - t55
                                    For i As Integer = 0 To mBitmap.Height - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(he * 4 + i * he * 4 - k) = rgbValues2(k + i * he * 4)
                                        Next
                                    Next
                                    he = mBitmap.Width - t66
                                    For i As Integer = 0 To mBitmap.Height - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(he * 4 + i * he * 4 - k + 1) = rgbValues2(k + i * he * 4 + 1)
                                        Next
                                    Next
                                    he = mBitmap.Width - t77
                                    For i As Integer = 0 To mBitmap.Height - Bpx
                                        For k As Integer = 0 To he * 4 - Bpx Step Bpx
                                            rgbValues(he * 4 + i * he * 4 - k + 2) = rgbValues2(k + i * he * 4 + 2)
                                        Next
                                    Next
                                End If
                                Marshal.Copy(rgbValues, 0, ptr, bytes) '
                                mBitmap.UnlockBits(bmpData)
                                mBitmap2.UnlockBits(bmpData2)
                                Dim elapsed_time As TimeSpan = Now.Subtract(start_time)
                                PictureBox1.Image = mBitmap
                            Catch
                            End Try
                            System.GC.Collect()
                        Catch ex As SystemException
                            MsgBox(ex.Message, MsgBoxStyle.Critical)
                        End Try
                    Next
                    System.GC.Collect()
                    System.IO.Directory.CreateDirectory(OpenFileDialog1.FileName & "(圖片加密程式解密檔)")
                    PictureBox1.Image.Save(OpenFileDialog1.FileName & "(圖片加密程式解密檔)" & "\" & str & "." & "png")
                Else
                    PictureBox1.Image = Image.FromFile(filess(ti2))
                    Dim ii9 As Integer
                    str = Mid(filess(ti2), InStr(filess(ti2), "\") + 1)
                    For ii9 = 1 To 99
                        str = Mid(str, InStr(str, "\") + 1)
                        If str2 = str Then Exit For
                        str2 = str
                    Next
                    str = str.Replace(".bmp", "")
                    str = str.Replace(".jpg", "")
                    str = str.Replace(".jpeg", "")
                    str = str.Replace(".gif", "")
                    str = str.Replace(".tif", "")
                    str = str.Replace(".png", "")
                    str = str.Replace(".BMP", "")
                    str = str.Replace(".JPG", "")
                    str = str.Replace(".JPEG", "")
                    str = str.Replace(".GIF", "")
                    str = str.Replace(".TIF", "")
                    str = str.Replace(".PNG", "")
                    TextBox2.Text = TextBox2.Text + str & "(解密失敗)" + ControlChars.CrLf
                End If
                ProgressBar1.Value = ti2
                ti2 += 1
            Else
                TextBox1.Enabled = True
                圖片ToolStripMenuItem.Text = "匯入圖片"
                ProgressBar1.Hide()
                ti2 = 0
                TextBox2.Text = TextBox2.Text + "解密完成" + ControlChars.CrLf
                With TextBox2
                    .SelectionStart = .Text.Length
                    .ScrollToCaret()
                End With
                Timer2.Enabled = False
                MsgBox("解密完成")
                Shell("Explorer.exe " & OpenFileDialog1.FileName & "(圖片加密程式解密檔)", vbNormalFocus)
            End If
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button3.Enabled = False
        Button4.Enabled = False
        ProgressBar1.Hide()
    End Sub
    Private Sub 圖片ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 圖片ToolStripMenuItem.Click
        If 圖片ToolStripMenuItem.Text = "匯入圖片" Then
            OpenFileDialog1.Filter = "圖片檔 (*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
                Dim a As New Bitmap(OpenFileDialog1.FileName)
                PictureBox1.Image = a
                PictureBox2.Image = a
                Dim r As Integer
                r = a.Width
                Dim t As Integer
                t = a.Height
                For iiiii = 0 To OpenFileDialog1.FileNames.Length - 1
                    System.GC.Collect()
                    filess(iiiii) = OpenFileDialog1.FileNames(iiiii)
                Next
                Button3.Enabled = True
                Button4.Enabled = True
                ProgressBar1.Maximum = OpenFileDialog1.FileNames.Length - 1
            End If
        Else
            Timer1.Enabled = False
            Timer2.Enabled = False
            圖片ToolStripMenuItem.Text = "匯入圖片"
            ProgressBar1.Hide()
        End If
    End Sub
End Class