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
    Public Class eventtsController
        Inherits System.Web.Mvc.Controller

        Private db As New Entities1

        ' GET: eventts
        Function Index() As ActionResult
            Return View(db.eventts.ToList())
        End Function
        Function adminIndex() As ActionResult
            Return View(db.eventts.ToList())
        End Function


        'EVENTS
        Function BouldersMarathon() As ActionResult
            Return View()
        End Function
        ' GET: eventts/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim eventt As eventt = db.eventts.Find(id)
            If IsNothing(eventt) Then
                Return HttpNotFound()
            End If
            Return View(eventt)
        End Function

        ' GET: eventts/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: eventts/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="eventID,eventName,eventDate")> ByVal eventt As eventt) As ActionResult
            If ModelState.IsValid Then
                db.eventts.Add(eventt)
                db.SaveChanges()
                Return RedirectToAction("adminIndex")
            End If
            Return View(eventt)
        End Function

        ' GET: eventts/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim eventt As eventt = db.eventts.Find(id)
            If IsNothing(eventt) Then
                Return HttpNotFound()
            End If
            Return View(eventt)
        End Function

        ' POST: eventts/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="eventID,eventName,eventDate")> ByVal eventt As eventt) As ActionResult
            If ModelState.IsValid Then
                db.Entry(eventt).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("adminIndex")
            End If
            Return View(eventt)
        End Function

        ' GET: eventts/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim eventt As eventt = db.eventts.Find(id)
            If IsNothing(eventt) Then
                Return HttpNotFound()
            End If
            Return View(eventt)
        End Function

        ' POST: eventts/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim eventt As eventt = db.eventts.Find(id)
            db.eventts.Remove(eventt)
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
