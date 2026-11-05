Imports MySql.Data.MySqlClient

Public Class frmRegister

    ' PIN Rahasia khusus Owner (hanya diketahui oleh Pemilik Warung)
    Private Const OWNER_SECRET_PIN As String = "9999"

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.Items.Clear()
        cmbRole.Items.Add("Kasir")
        cmbRole.Items.Add("Owner")
        cmbRole.SelectedIndex = 0 ' Default Kasir

        txtOwnerPin.Enabled = False
        txtOwnerPin.Clear()
    End Sub

    ' Event saat Role dipilih
    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        If cmbRole.SelectedItem.ToString() = "Owner" Then
            txtOwnerPin.Enabled = True
            MessageBox.Show("Mendaftar sebagai Owner wajib memasukkan Kode Validasi Owner!", "Otorisasi Owner", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            txtOwnerPin.Enabled = False
            txtOwnerPin.Clear()
        End If
    End Sub

    ' Tombol Eksekusi Register
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' 1. Validasi Input Kosong
        If String.IsNullOrWhiteSpace(txtNamaLengkap.Text) OrElse
           String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Semua kolom bertanda wajib harus diisi!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 2. Validasi Konfirmasi Password
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Konfirmasi password tidak cocok!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 3. Validasi Rahasia Verifikasi Owner
        Dim selectedRole As String = cmbRole.SelectedItem.ToString()
        If selectedRole = "Owner" Then
            If txtOwnerPin.Text.Trim() <> OWNER_SECRET_PIN Then
                MessageBox.Show("Kode Validasi Owner SALAH! Akses ditolak.", "Otorisasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        ' 4. Simpan User Baru ke Database MySQL
        Try
            Using koneksi As MySqlConnection = BukaKoneksi()
                ' Cek apakah username sudah pernah terdaftar
                Dim checkSql As String = "SELECT COUNT(*) FROM tbl_user WHERE username = @user"
                Using checkCmd As New MySqlCommand(checkSql, koneksi)
                    checkCmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim())
                    If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                        MessageBox.Show("Username sudah digunakan! Cari username lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using

                ' Simpan ke database
                Dim insertSql As String = "INSERT INTO tbl_user (username, password_hash, nama_lengkap, role, status_akun) VALUES (@user, @pass, @nama, @role, 'Aktif')"
                Using cmd As New MySqlCommand(insertSql, koneksi)
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim())
                    cmd.Parameters.AddWithValue("@nama", txtNamaLengkap.Text.Trim())
                    cmd.Parameters.AddWithValue("@role", selectedRole)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Registrasi Akun (" & selectedRole & ") Berhasil! Silakan Login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Setelah berhasil, langsung pindah ke Form Login
            Me.Hide()
            frmLogin.Show()

        Catch ex As Exception
            MessageBox.Show("Gagal mendaftar: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class