Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports selati_

Namespace Controllers
    Public Class resultsController
        Inherits System.Web.Mvc.Controller

        Private db As New Entities1

        ' GET: results
        Function Index() As ActionResult
            Dim results = db.results
            Return View(results.ToList())
        End Function

        Function adminIndex() As ActionResult
            Dim results = db.results
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
        'Gender


        ' GET: results/Create
        Function Create() As ActionResult
            ViewBag.eventID = New SelectList(db.eventts, "eventID", "eventName")
            ViewBag.userID = New SelectList(db.users, "userID", "firstName")
            Return View()
        End Function

        ' POST: results/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="resultID,batch,gender,class,raceNumber,position,posGen,category,posCat,status,time,eventID,userID")> ByVal result As result) As ActionResult

            'ViewBag.Fleet_Id_Horse = New SelectList(db.Fleets.Where(Function(p) p.Type = "Horse"), "Fleet_Id", "Vehicle")

            If ModelState.IsValid Then
                db.results.Add(result)
                db.SaveChanges()
                Return RedirectToAction("adminIndex")
            End If

            ViewBag.eventID = New SelectList(db.eventts, "eventID", "eventName", result.eventID)
            ViewBag.userID = New SelectList(db.users, "userID", "firstName", result.userID)
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
            ViewBag.userID = New SelectList(db.users, "userID", "firstName", result.user)
            Return View(result)
        End Function

        ' POST: results/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="resultID,batch,gender,class,raceNumber,position,posGen,category,posCat,status,time,eventID,userID")> ByVal result As result) As ActionResult
            If ModelState.IsValid Then
                db.Entry(result).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("adminIndex")
            End If
            ViewBag.eventID = New SelectList(db.eventts, "eventID", "eventName", result.eventID)
            ViewBag.userID = New SelectList(db.users, "userID", "firstName", result.user)
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
