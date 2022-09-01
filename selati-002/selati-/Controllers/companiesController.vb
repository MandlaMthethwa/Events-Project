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
    Public Class companiesController
        Inherits System.Web.Mvc.Controller

        Private db As New Entities1

        ' GET: companies
        Function Index() As ActionResult
            Dim companies = db.companies
            Return View(companies.ToList())
        End Function

        ' GET: companies/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim company As company = db.companies.Find(id)
            If IsNothing(company) Then
                Return HttpNotFound()
            End If
            Return View(company)
        End Function

        ' GET: companies/Create
        Function Create() As ActionResult
            ViewBag.companyID = New SelectList(db.companies, "companyID", "companyName")
            ViewBag.companyID = New SelectList(db.companies, "companyID", "companyName")
            ViewBag.eventID = New SelectList(db.eventts, "eventID", "eventName")
            Return View()
        End Function

        ' POST: companies/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="companyID,companyName,companyUsername,websiteURL,companyRegNum,companyVATNum,eventID")> ByVal company As company) As ActionResult
            If ModelState.IsValid Then
                db.companies.Add(company)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.companyID = New SelectList(db.companies, "companyID", "companyName", company.companyID)
            ViewBag.companyID = New SelectList(db.companies, "companyID", "companyName", company.companyID)
            ViewBag.eventID = New SelectList(db.eventts, "eventID", "eventName", company.eventID)
            Return View(company)
        End Function

        ' GET: companies/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim company As company = db.companies.Find(id)
            If IsNothing(company) Then
                Return HttpNotFound()
            End If
            ViewBag.companyID = New SelectList(db.companies, "companyID", "companyName", company.companyID)
            ViewBag.companyID = New SelectList(db.companies, "companyID", "companyName", company.companyID)
            ViewBag.eventID = New SelectList(db.eventts, "eventID", "eventName", company.eventID)
            Return View(company)
        End Function

        ' POST: companies/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="companyID,companyName,companyUsername,websiteURL,companyRegNum,companyVATNum,eventID")> ByVal company As company) As ActionResult
            If ModelState.IsValid Then
                db.Entry(company).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.companyID = New SelectList(db.companies, "companyID", "companyName", company.companyID)
            ViewBag.companyID = New SelectList(db.companies, "companyID", "companyName", company.companyID)
            ViewBag.eventID = New SelectList(db.eventts, "eventID", "eventName", company.eventID)
            Return View(company)
        End Function

        ' GET: companies/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim company As company = db.companies.Find(id)
            If IsNothing(company) Then
                Return HttpNotFound()
            End If
            Return View(company)
        End Function

        ' POST: companies/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim company As company = db.companies.Find(id)
            db.companies.Remove(company)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
