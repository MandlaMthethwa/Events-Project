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
    Public Class divisionsController
        Inherits System.Web.Mvc.Controller

        Private db As New Entities1

        ' GET: divisions
        Function Index() As ActionResult
            Dim divisions = db.divisions
            Return View(divisions.ToList())
        End Function
        Function adminIndex() As ActionResult
            Dim divisions = db.divisions
            Return View(divisions.ToList())
        End Function

        ' GET: divisions/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim division As division = db.divisions.Find(id)
            
            If IsNothing(division) Then
                Return HttpNotFound()
            End If
            Return View(division)
        End Function

        ' GET: divisions/Create
        Function Create() As ActionResult
            ViewBag.companyID = New SelectList(db.companies, "companyID", "companyName")
            ViewBag.event = New SelectList(db.eventts, "eventID", "eventName")
            Return View()
        End Function

        ' POST: divisions/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="divisionID,distance,eventTime,eventType,eventID,companyID")> ByVal division As division) As ActionResult
            If ModelState.IsValid Then
                db.divisions.Add(division)
                db.SaveChanges()
                Return RedirectToAction("adminIndex")
            End If
            ViewBag.companyID = New SelectList(db.companies, "companyID", "companyName", division.companyID)
            ViewBag.event = New SelectList(db.eventts, "eventID", "eventName", division.eventID)
            Return View(division)
        End Function

        ' GET: divisions/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim division As division = db.divisions.Find(id)
            If IsNothing(division) Then
                Return HttpNotFound()
            End If
            ViewBag.companyID = New SelectList(db.companies, "companyID", "companyName", division.companyID
                                               )
            ViewBag.event = New SelectList(db.eventts, "eventID", "eventName", division.eventID)
            Return View(division)
        End Function

        ' POST: divisions/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="divisionID,distance,eventTime,eventType,eventID,companyID")> ByVal division As division) As ActionResult
            If ModelState.IsValid Then
                db.Entry(division).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("adminIndex")
            End If
            ViewBag.companyID = New SelectList(db.companies, "companyID", "companyName", division.companyID)
            ViewBag.event = New SelectList(db.eventts, "eventID", "eventName", division.eventID)
            Return View(division)
        End Function

        ' GET: divisions/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim division As division = db.divisions.Find(id)
            If IsNothing(division) Then
                Return HttpNotFound()
            End If
            Return View(division)
        End Function

        ' POST: divisions/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim division As division = db.divisions.Find(id)
            db.divisions.Remove(division)
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
