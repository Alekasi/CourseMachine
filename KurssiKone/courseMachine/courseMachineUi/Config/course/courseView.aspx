<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="courseView.aspx.cs" Inherits="courseMachineUi.Views.Config.course.courseView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div ng-controller="configController">
        
    <div class="sideBar" id="sideBar">
        <div class="courseInfo" id="courseInfo">

        </div>
        <div class="courseTree" id="courseTree">
            <div>
                <div class="alert alert-{{treeTableAlertType}}" role="alert" ng-show="{{treeTableNotification}}">
                    {{treeTableNotificationMessage}}
                </div>
                <input type="button" ng-click="fetchTree()" value="fetch"/>
                <!-- Parents start -->
                <table class="treeTable" ng-repeat="parent in parents">
                    <tr class="parentTable" ng-click="displaySettings('parent', parent.parentId)">
                        <th class="parentTableCell" colspan="2">{{parent.name}}</th>
                        <th class="parentTableCell"></th>
                        <th class="parentTableCell">
                            <input class="floatRigth" type="button" value="Del" ng-click="deleteParent(parent.parentId)" />
                        </th>
                    </tr>
                    <tr class="childTable">
                        <td class="childTablecell">Name</td>
                        <td class="childTablecell"></td>
                        <td class="childTablecell">Btn</td>
                        <td class="childTablecell">Del</td>
                    </tr>
                    <tr class="childTable" ng-repeat="child in parent.child">
                        <td class="childTablecell" colspan="2" ng-click="displaySettings('parameter', child.childId)">{{child.name}}</td>
                        <td class="childTablecell"></td>
                        <td class="childTablecell">
                            <input type="button" ng-click="deleteChild(child.childId)" value="Del"/>
                        </td>
                    </tr>
                    <tr class="childButton tableButton">
                        <td colspan="4">
                            <input type="text" placeholder="ChildName" ng-model="childName"/>
                            <input type="button" ng-click="createChild(childName, parent.parentId)" value="Create"/>
                        </td>
                    </tr>
                </table>
            </div>
            <div id="parentButton">
                <input type="text"  id="parentName" name="parentName" placeholder="ParentName" ng-model="parentName"/>
                <input type="button" ng-click="createParent(parentName)" value="Create" id="nappi" />
            </div>
        </div>
    </div>
    <!-- CourseConfig -->
    <div class="courseView" id="courseView">
        <div class="alert alert-{{parameterAlertType}}" role="alert" ng-show="{{parameterNotification}}">
            {{parameterNotificationMessage}}
        </div>

        <input class="saveBtn" type="button" ng-click="saveParameter()" value="Save" />
            <!-- Show if there is active childDisplay -->
        <div class="parameterContainer" ng-show="showParameters" ng-repeat="child in parameters track by child.parameterId">
            <div class="parameterBox" ng-switch="child.type">
                <div ng-switch-when="textarea">
                    <textarea ng-change="modify(true)" class="textAreaInput" ng-model="child.value">{{child.value}}</textarea>
                </div>
                <div ng-switch-when="header">
                    <input ng-change="modify(true)" class="headerInput" type="text" ng-model="child.value" value="{{child.value}}" placeholder="Header"/>
                </div>
                <div class="imageBox" ng-switch-when="img">
                    <img data-ng-src="{{child.value}}" data-err-src="../../Content/image/imgnull.png" onchange="angular.element(this).scope().imgChange()" alt="Image"/>
                    <input class="imgFile" type="file" fileread="child.value" />
                </div>
                <div ng-switch-when="imgCarousel">

                </div>
                <div ng-switch-when="video">
                    <input type="file" />
                </div>
                <div ng-switch-when="filedrop">
                    <form action="" class="dropzone">
                        <div class="fallback imgFile">
                            <input type="file"/>
                        </div>
                    </form>
                </div>

                <!-- Assigments -->

                <div ng-switch-when="shortanswer">
                    <input ng-change="modify(true)" type="text" class="shortAnswer" ng-model="child.value" value="{{child.value}}" placeholder="You can insert tips here, that show up as this text"/>
                </div>
                <div ng-switch-when="longanswer">
                    <textarea ng-change="modify(true)" class="longAnswer" ng-model="child.value" placeholder="You can insert tips here, that show up as this text">
                        {{child.value}}
                    </textarea>
                </div>
                <div ng-switch-when="fileassigment">
                    <input ng-change="modify(true)" type="text" placeHolder="fileAssigmentText" ng-model="child.value" value="{{child.value}}"/>
                </div>

                <!-- Options -->

                <div class="parameterButton">
                    <input type="button" value="Del" ng-click="deleteParameter(child.parameterId)" />
                </div>
            </div>
        </div>
        <div class="parameterButtons"  ng-show="showParameters">
            <input class="parameterBtn" type="button" value="header" ng-click="createParameter('header')"/>
            <input class="parameterBtn" type="button" value="textarea" ng-click="createParameter('textarea')"/>
            <input class="parameterBtn" type="button" value="Img" ng-click="createParameter('img')"/>
            <input class="parameterBtn" type="button" value="Video" ng-click="createParameter('video')"/>
            <!-- Tasks -->
            <input class="parameterBtn" type="button" value="ShortAnswer" ng-click="createParameter('shortanswer')"/>
            <input class="parameterBtn" type="button" value="longAnswer" ng-click="createParameter('longanswer')"/>
            <input class="parameterBtn" type="button" value="fileAssigment" ng-click="createParameter('fileassigment')"/>
        </div>
        
    </div>
        
            <!-- Show if there is active  Parent Options-->
        <div class="courseView parentOptions" ng-show="parentOptions">
            <input type="text" ng-value="parentOptions.parentName" ng-model="parentOptions.parentName" placeholder="ParentName" />
            <input type="datetime" ng-model="parentOptions.releaseDate"/>
        </div>
        
            <!-- Show if there is active  Child Options-->
        <div class="courseView childOptions" ng-show="childOptions">
            <h2><input type="text" ng-value="currentChildSettings.name" ng-model="currentChildSettings.name" /></h2>
            <input type="datetime" ng-value="currentChildSettings.options.releaseDate" ng-model="currentChildSettings.options.releaseDate" />
        </div>
            <!-- Show if there is active  Course Options-->
        <div class="courseView courseOptions" ng-show="courseOptions">
            <input type="text" ng-value="courseSettings.name" ng-model="courseSettings.name" placeholder="CourseName"/>
            <div>
                <h2>Info</h2>
                <textarea>
                    {{courseSettings.info}}
                </textarea>
            </div>
        </div>
    </div>
</asp:Content>
