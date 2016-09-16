<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="submissions.aspx.cs" Inherits="SAM2017.submissions" %>
<%@ Import Namespace="SAM2017.Models" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="float: right; margin-right: 15px">
                <button type="submit">Logout</button>
            </div>
            <br />
            <div>
                <fieldset>
                    <legend>Submissions
                    </legend>
                    <%--<table>
                        <th>Paper Title </th>
                        <th>
                            <button type="submit">Assign PCM</button></th>
                        <th>
                            <button type="submit">Review</button></th>
                        <th>
                            <button type="submit">Rate</button></th>
                        <th>
                            <button type="submit">Generate report </button>
                        </th>
                        <th>
                            <button type="submit">Assign PCM</button></th>
                        <td>
                            <input type="checkbox" name="vehicle1" value="Bike">
                            Preffered?(Check for yes)</td>
                        <tr>
                            <th>Paper Title </th>
                            <th>
                                <button type="submit">Assign PCM</button></th>
                            <th>
                                <button type="submit">Review</button></th>
                            <th>
                                <button type="submit">Rate</button></th>
                            <th>
                                <button type="submit">Generate report </button>
                            </th>
                            <th>
                                <button type="submit">Assign PCM</button></th>
                            <td>
                                <input type="checkbox" name="vehicle1" value="Bike">
                                Preffered?(Check for yes)</td>
                        </tr>
                    </table>--%>

                    <asp:GridView ID="SubmissionsGridView" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
                        runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="Title" HeaderText="Title" />
                            <asp:BoundField DataField="Submitter" HeaderText="Submitter" />
                            
                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:Button runat="server" ID="ReviewButton" Text="Review" Enabled='<%# ((Submission)Eval("Submission")).CanReview() %>' 
                                        CommandArgument='<%# ((Submission)Eval("Submission")) %>' OnCommand="ReviewButton_OnCommand" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:Button runat="server" ID="RateButton" Text="Rate" Enabled='<%# Eval("CanRate") %>' 
                                        CommandArgument='<%# Eval("Id") %>' OnCommand="RateButton_OnCommand" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:Button runat="server" ID="GenerateReportButton" Text="Generate Report" Enabled='<%# Eval("CanGenerateReport") %>'
                                        CommandArgument='<%# Eval("Id") %>' OnCommand="GenerateReportButton_OnCommand"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:Button runat="server" ID="AssignPCMButton" Text="Assign PCM" Enabled='<%# Eval("CanAssignPCM") %>' 
                                        CommandArgument='<%# Eval("Id") %>' OnCommand="AssignPCMButton_OnCommand"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:CheckBox runat="server" ID="PreferredCheckBox" Enabled='<%# Eval("CanPrefer") %>' Checked='<%# Eval("Preferred") %>' 
                                        OnCheckedChanged="PreferredCheckBox_OnCheckedChanged"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>


                    <%--<asp:GridView ID="GridView1" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
                        runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="Title" HeaderText="Title" />
                            <asp:BoundField DataField="Name" HeaderText="Name" ItemStyle-Width="30" />
                            <asp:BoundField DataField="Country" HeaderText="Country" ItemStyle-Width="150" />

                            <asp:ButtonField ButtonType="Button" Text="This Button" />



                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:Button runat="server" ID="button2" CommandName="SendMail" Text="SendMail" CommandArgument='<%# Eval("title") %>' OnClick="button2_OnClick" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:Button runat="server" Enabled='<%# (bool)Eval("someVal") %>' ID="button3" CommandName="Fake" Text="Fake" CommandArgument='<%# Eval("name") %>' OnCommand="AssignPCMButton_OnCommand" />
                                </ItemTemplate>
                            </asp:TemplateField>

                        </Columns>
                    </asp:GridView>--%>
                </fieldset>
            </div>
        </div>
    </form>
</body>
</html>
