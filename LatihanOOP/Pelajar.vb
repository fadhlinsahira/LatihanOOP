﻿Public Class Pelajar
    Private strNoMatrik As String
    Sub New(ByVal strNoMatrik As String)
        Me.strNoMatrik = strNoMatrik
    End Sub

    Public Function Politeknik() As String
        Dim strKodPoli As String = strNoMatrik.Substring(0, 2)

        If strKodPoli = "18" Then
            Return "PTSS"
        Else
            Return "Not PTSS"

        End If

    End Function

    Public Function Program() As String
        Dim strKodCourse As String = strNoMatrik.Substring(2, 3)

        If strKodCourse = "DDT" Then
            Return "Diploma Teknologi Maklumat"
        Else
            Return "NOT Diploma Teknologi Maklumat "

        End If
    End Function

    Public Function Ambilan() As String
        Dim strKodAmbilan As String = strNoMatrik.Substring(5, 2)
        Dim strKodTahun As String = strNoMatrik.Substring(8, 1)

        If strKodAmbilan = "19F" Then
            If strKodTahun = "1" Then

                Return "Sesi JUN 2019"
            ElseIf strKodTahun = "2" Then

                Return "Sesi December 2019 "

            End If

        Else Return ("Not Sesi 2019")
        End If


    End Function
End Class
