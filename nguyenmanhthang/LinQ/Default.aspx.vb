Imports BusinessObject

Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BindData(True)
    End Sub


    Public Function BindData(ByVal _Accounts_Status As Boolean)
        Dim dsAccounts As New DataSet
        dsAccounts = AccountsBO.SelectListByAccounts_Status(_Accounts_Status)
        grvDemo.DataSource = dsAccounts
        grvDemo.DataBind()
        Dim emaDSTokhai = dsAccounts.Tables(0).AsEnumerable()
        Dim res = From tk In emaDSTokhai Select tk
        Dim source As IEnumerable = res
        lblTongSoBanGhi.Text = res.Count()
        lblTongSoView.Text = CLng(Aggregate item In res Where Not (item!Accounts_Like.Equals(DBNull.Value)) Into Sum(CLng(item!Accounts_Like)))
        'Dim sum As Single = res.Sum(F)
        'lblTongSoView.Text = res.Sum(Function(ByVal source As  Integer))
        Return True
    End Function

    'Public Shared Function Sum(Of TSource)(source As IEnumerable(Of TSource), selector As Func(Of TSource, Integer)) As Integer
    '    'Usage
    '    Dim source As IEnumerable(Of TSource)
    '    Dim selector As Func(Of TSource, Integer)
    '    Dim returnValue As Integer
    '    Return returnValue = source.Sum(selector)


End Class