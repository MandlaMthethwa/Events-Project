Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Microsoft.AspNet.Identity
Imports PagedList
Imports selati_
Imports PagedList.Mvc


Namespace Controllers
    Public Class resultsController
        Inherits System.Web.Mvc.Controller

        Private db As New Entities1

        ' GET: results
        Function Index(ByVal sortOrder As String, ByVal currentFilter As String, ByVal searchString As String, ByVal page As Integer?) As ActionResult

            ViewBag.CurrentSort = sortOrder
            ViewBag.FirstNameSortParm = If(sortOrder = "first_name", "first_name_desc", "first_name")
            ViewBag.LastNameSortParm = If(sortOrder = "last_name", "last_name_desc", "last_name")
            ViewBag.PositionSortParm = If(sortOrder = "position", "position_desc", "position")


            If searchString IsNot Nothing Then
                page = 1
            Else
                searchString = currentFilter
            End If
            ViewBag.CurrentFilter = searchString
            Dim email = User.Identity.GetUserName()
            Dim results = From s In db.results.Where(Function(f) f.emailAddress = email) Select s
            If Not String.IsNullOrEmpty(searchString) Then
                results = results.Where(Function(s) s.firstName.ToUpper().Contains(searchString.ToUpper()) _
                                              Or s.lastName.ToUpper().Contains(searchString.ToUpper()))
            End If

            Select Case sortOrder
                Case "first_name_desc"
                    results = results.OrderByDescending(Function(s) s.firstName)
                Case "first_name"
                    results = results.OrderBy(Function(s) s.firstName)
                Case "last_name_desc"
                    results = results.OrderByDescending(Function(s) s.lastName)
                Case "last_name"
                    results = results.OrderBy(Function(s) s.lastName)
                Case "position"
                    results = results.OrderBy(Function(s) s.position)
                Case "position_desc"
                    results = results.OrderByDescending(Function(s) s.position)
                Case Else
                    results = results.OrderBy(Function(s) s.lastName)
            End Select

            Dim pageSize As Integer = 3
            Dim pageNumber As Integer = (If(page, 1))
            Return View(results.ToPagedList(pageNumber, pageSize))
        End Function

        Function adminIndex(ByVal sortOrder As String, ByVal currentFilter As String, ByVal searchString As String, ByVal page As Integer?) As ActionResult

            ViewBag.CurrentSort = sortOrder
            ViewBag.FirstNameSortParm = If(sortOrder = "first_name", "first_name_desc", "first_name")
            ViewBag.LastNameSortParm = If(sortOrder = "last_name", "last_name_desc", "last_name")
            ViewBag.PositionSortParm = If(sortOrder = "position", "position_desc", "position")


            If searchString IsNot Nothing Then
                page = 1
            Else
                searchString = currentFilter
            End If
            ViewBag.CurrentFilter = searchString
            Dim email = User.Identity.GetUserName()
            Dim results = From s In db.results Select s
            If Not String.IsNullOrEmpty(searchString) Then
                results = results.Where(Function(s) s.firstName.ToUpper().Contains(searchString.ToUpper()) _
                                              Or s.lastName.ToUpper().Contains(searchString.ToUpper()))
            End If

            Select Case sortOrder
                Case "first_name_desc"
                    results = results.OrderByDescending(Function(s) s.firstName)
                Case "first_name"
                    results = results.OrderBy(Function(s) s.firstName)
                Case "last_name_desc"
                    results = results.OrderByDescending(Function(s) s.lastName)
                Case "last_name"
                    results = results.OrderBy(Function(s) s.lastName)
                Case "position"
                    results = results.OrderBy(Function(s) s.position)
                Case "position_desc"
                    results = results.OrderByDescending(Function(s) s.position)
                Case Else
                    results = results.OrderBy(Function(s) s.lastName)
            End Select

            Dim pageSize As Integer = 3
            Dim pageNumber As Integer = (If(page, 1))
            Return View(results.ToPagedList(pageNumber, pageSize))
        End Function
        Function allResults() As ActionResult

            Return View()
        End Function

        Function thirstResults(searchString As String) As ActionResult
            Dim results = From s In db.results.Where(Function(f) f.eventID = 2) Select s
            If Not String.IsNullOrEmpty(searchString) Then
                results = results.Where(Function(s) s.firstName.ToUpper().Contains(searchString.ToUpper()) _
                                        Or s.lastName.ToUpper().Contains(searchString.ToUpper()))
            End If
            Return View(results.ToList())
        End Function
        ' GET: results/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim result As result = db.results.Find(id)
            If IsNothing(result) Then
                Return HttpNotFound()
            End If
            Return View(result)
        End Function

        ' GET: results/Create
        Function Create() As ActionResult
            ViewBag.eventID = New SelectList(db.eventts, "eventID", "eventName")
            Return View()
        End Function

        ' POST: results/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="resultID,lastName,firstName,emailAddress,batch,gender,class,raceNumber,position,posGen,category,posCat,status,time,eventID")> ByVal result As result) As ActionResult


            If ModelState.IsValid Then
                db.results.Add(result)
                db.SaveChanges()
                Return RedirectToAction("adminIndex")
            End If

            ViewBag.eventID = New SelectList(db.eventts, "eventID", "eventName", result.eventID)
            Return View(result)
        End Function

        ' GET: results/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim result As result = db.results.Find(id)
            If IsNothing(result) Then
                Return HttpNotFound()
            End If
            ViewBag.eventID = New SelectList(db.eventts, "eventID", "eventName", result.eventID)
            Return View(result)
        End Function

        ' POST: results/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="resultID,lastName,firstName,emailAddress,batch,gender,class,raceNumber,position,posGen,category,posCat,status,time,eventID")> ByVal result As result) As ActionResult
            If ModelState.IsValid Then
                db.Entry(result).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("adminIndex")
            End If
            ViewBag.eventID = New SelectList(db.eventts, "eventID", "eventName", result.eventID)
            Return View(result)
        End Function

        ' GET: results/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim result As result = db.results.Find(id)
            If IsNothing(result) Then
                Return HttpNotFound()
            End If
            Return View(result)
        End Function

        ' POST: results/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim result As result = db.results.Find(id)
            db.results.Remove(result)
            db.SaveChanges()
            Return RedirectToAction("adminIndex")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
