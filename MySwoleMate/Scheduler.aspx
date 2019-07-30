<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="Scheduler.aspx.cs" Inherits="MySwoleMate.Scheduler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="first">
        <div class="container">
            <div class="row">
                <div class="col-xs-10">
                    <h1>Scheduler</h1>
                </div>
                <div class="col-xs-2">
                    <a href="~/AddNewAppointment.aspx" runat="server" class="btn btn-success">Add New Appointment</a>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12 text-center">
                    <asp:GridView ID="AppointmentList" runat="server" CssClass="table table-bordered text-left"
                        AutoGenerateColumns="False" OnRowDeleting="AppointmentList_RowDeleting" DataKeyNames="ScheduleID">
                        <Columns>
                            <asp:HyperLinkField Text="Edit" DataNavigateUrlFields="ScheduleID"
                                DataNavigateUrlFormatString="~/EditSchedule.aspx?ScheduleID={0}" ControlStyle-CssClass="btn btn-success btn-xs"
                                ItemStyle-CssClass="text-center bg-warning" />
                            <asp:TemplateField ItemStyle-CssClass="text-center bg-warning">
                                <ItemTemplate>
                                    <%--The Delete functionality is --%>
                                    <asp:Button runat="server" ID="DeleteButton" CommandName="Delete"
                                        CssClass="btn btn-xs btn-default" Text="Delete"
                                        OnClientClick="if(!confirm('Are you sure you wish to delete this appointment?')) return false;" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="AppointmentDateAndTime" HeaderText="Appointment Date & Time" ItemStyle-BackColor="#f0ad4e"/>
                            <asp:BoundField DataField="TraineeName" HeaderText="Trainee Name" ItemStyle-BackColor="#f0ad4e"/>
                            <asp:BoundField DataField="LastModified" HeaderText="Last Modified" ItemStyle-BackColor="#f0ad4e"/>
                            <asp:HyperLinkField Text="Enter Measurements" DataNavigateUrlFields="ScheduleID" 
                                DataNavigateUrlFormatString="~/AddMeasurement.aspx?ScheduleID={0}" ControlStyle-CssClass="btn btn-success btn-xs"
                                ItemStyle-CssClass="text-center bg-warning" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
