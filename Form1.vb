Option Strict On
Option Explicit On

Public Class Form1

    ' ****************************************************************************
    ' Surname, Initials: Sikhipha A
    ' Student Number: 223068260
    ' Practical: P24IFM-04
    ' Class name: Form1
    ' ****************************************************************************

    'Variable declaration
    Private initial_allowance As Double
    Private transactions(3) As Double
    Private total As Double
    Private balance(3) As Double
    Private average As Double
    Private counter As Integer
    Private remainingBalance As Double = initial_allowance - transactions.Sum()
    Private totalTransactions As Double = transactions.Sum()
    Private transactionAmount As Double
    Private input As String



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'we set up the grid

        grd_transactions.Row = 1
        grd_transactions.Col = 0
        grd_transactions.Text = "Transactions"

        grd_transactions.Row = 2
        grd_transactions.Col = 0
        grd_transactions.Text = "Balance"

        grd_transactions.Row = 3
        grd_transactions.Col = 0
        grd_transactions.Text = "average"

        grd_transactions.Row = 0
        grd_transactions.Col = 1
        grd_transactions.Text = "week 1"

        grd_transactions.Row = 0
        grd_transactions.Col = 2
        grd_transactions.Text = "week 2"

        grd_transactions.Row = 0
        grd_transactions.Col = 3
        grd_transactions.Text = "week 3"

        grd_transactions.Row = 0
        grd_transactions.Col = 4
        grd_transactions.Text = "week 4"


    End Sub


    Private Sub btn_initial_allowance_Click(sender As Object, e As EventArgs) Handles btn_initial_allowance.Click
        initial_allowance = CDbl(InputBox("Enter your monthly allowance"))
        initial_allowance_input.Text = CStr(initial_allowance)
        balance(0) = initial_allowance

    End Sub

    Private Sub btn_make_transaction_Click(sender As Object, e As EventArgs) Handles btn_make_transaction.Click

        input = InputBox("Enter transaction:", "Transaction", "")

        If input <> "" Then
            transactionAmount = CDbl(input)
            CheckRemainingBalance(transactionAmount)
        End If
    End Sub

    Private Sub CheckRemainingBalance(ByVal transactionAmount As Double)

        If transactionAmount > remainingBalance Then
            MessageBox.Show("Transaction amount exceeds remaining balance.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            checkWarning(remainingBalance)
            ' Find the first empty slot in transactions array
            For i = 0 To 3
                If transactions(i) = 0 Then
                    ' Add transaction to transactions array
                    transactions(i) = transactionAmount

                    balance(i) = initial_allowance - (totalTransactions + transactionAmount)
                    Exit For ' Exit the loop after successfully adding the transaction
                End If
            Next

            ' Update grid with transactions and recalculate balance and average
            UpdateGrid()
        End If
    End Sub

    Private Sub UpdateGrid()
        If transactions(0).ToString() <> "" Then
            grd_transactions.Col = 1
            grd_transactions.Row = 1
            grd_transactions.Text = transactions(0).ToString()

            'balance(0) -= transactions(0)

            grd_transactions.Row = 2
            grd_transactions.Col = 1
            grd_transactions.Text = balance(0).ToString()
        End If

        If transactions(1).ToString() <> "" Then
            grd_transactions.Col = 2
            grd_transactions.Row = 1
            grd_transactions.Text = transactions(1).ToString()

            'balance(1) -= transactions(1)

            grd_transactions.Row = 2
            grd_transactions.Col = 2
            grd_transactions.Text = balance(1).ToString()
        End If


        If transactions(2).ToString() <> "" Then
            grd_transactions.Col = 3
            grd_transactions.Row = 1
            grd_transactions.Text = transactions(2).ToString()

            'balance(2) -= transactions(2)

            grd_transactions.Row = 2
            grd_transactions.Col = 3
            grd_transactions.Text = balance(2).ToString()
        End If

        If transactions(3).ToString() <> "" Then
            grd_transactions.Col = 4
            grd_transactions.Row = 1
            grd_transactions.Text = transactions(3).ToString()

            'balance(3) -= transactions(3)

            grd_transactions.Row = 2
            grd_transactions.Col = 4
            grd_transactions.Text = balance(3).ToString
        End If
    End Sub

    Private Sub checkWarning(ByVal remaining_balance As Double)
        If initial_allowance - remaining_balance <= 50 Then
            MessageBox.Show("Your balance is less than R50")
        End If

    End Sub
End Class
