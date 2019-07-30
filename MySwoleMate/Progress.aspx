<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="Progress.aspx.cs" Inherits="MySwoleMate.Progress" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="first">
        <div class="container">
            <div class="row">
                <div class="col-xs-10">
                    <h1>Progress Tracker</h1>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12 text-center">
                    <asp:GridView ID="TraineeProgressList" runat="server" CssClass="table table-bordered text-left"
                        AutoGenerateColumns="False" OnRowDeleting="TraineeProgressList_RowDeleting" DataKeyNames="TraineeID">
                        <Columns>
                            <asp:HyperLinkField Text="Trainee Name" DataNavigateUrlFields="TraineeID"
                                DataNavigateUrlFormatString="~/EditTrainee.aspx?TraineeID={0}" ControlStyle-CssClass="btn btn-success btn-xs"
                                ItemStyle-CssClass="text-center bg-warning" />
                            
                            <asp:BoundField DataField="AppointmentDateAndTime" HeaderText="Appointment Date & Time" ItemStyle-BackColor="#f0ad4e"/>
                            

                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
