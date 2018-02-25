<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="courseHub.aspx.cs" Inherits="courseMachineUi.Main.courseHub" %>

<asp:Content ID="courseHub" ContentPlaceHolderID="MainContent" runat="server">
    <div ng-controller="hubController">
        <div class="createBox">
            <input type="text" ng-model="courseName" placeholder="CourseName" />
            <input type="button" ng-click="createCourse(courseName)" value="Create" />
        </div>
        <input type="button" ng-click="fetchCourses()" value="REFRESH"/>
    <div class="courseContainer" ng-repeat="course in courses">
        <div class="courseBox">
            <h2>{{course.name}}</h2>
            <img src="course.img" alt="image" />
            <p>{{course.information}}</p>
            <input type="button" ng-click="displayDetails(course.courseId)" value="Go" />
        </div>
    </div>
</div>
</asp:Content>
