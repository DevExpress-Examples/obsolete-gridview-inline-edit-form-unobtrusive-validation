Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Mvc
Imports Inline_Unobtrusive.Models

Namespace Inline_Unobtrusive.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View(GetData())
		End Function

		Public Function GridViewPartial() As ActionResult
			Return PartialView(GetData())
		End Function

		<HttpPost, ValidateInput(False)> _
		Public Function InlineEditingAddNewPartial(ByVal customer As Customer) As ActionResult
			If ModelState.IsValid Then
				Try
					'insert data in the data source
				Catch e As Exception
					ViewData("EditError") = e.Message
				End Try
			Else
				ViewData("EditError") = "Please, correct all errors."
			End If
			Return PartialView("GridViewPartial", GetData())
		End Function
		<HttpPost, ValidateInput(False)> _
		Public Function InlineEditingUpdatePartial(ByVal customer As Customer) As ActionResult
			If ModelState.IsValid Then
				Try
					'update data in the data source
				Catch e As Exception
					ViewData("EditError") = e.Message
				End Try
			Else
				ViewData("EditError") = "Please, correct all errors."
			End If
			Return PartialView("GridViewPartial", GetData())
		End Function

		Public Shared Function GetData() As IEnumerable(Of Customer)
			Return Enumerable.Range(0, 10).Select(Function(i) New Customer() With {.ID = i, .City = "City " & i, .Name = "Customer " & i})
		End Function
	End Class

End Namespace