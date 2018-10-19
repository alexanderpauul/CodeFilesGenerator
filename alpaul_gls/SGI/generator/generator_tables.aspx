<%@ Page Title="" Language="C#" MasterPageFile="~/master/base.master" AutoEventWireup="true" CodeBehind="generator_tables.aspx.cs" Inherits="alpaul_gls.SGI.generator.generator_tables" %>

<asp:Content ID="head" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .alert-box.info {
            background-color: #a0d3e8;
            border-color: #74bfdd;
            color: #4f4f4f;
        }

        .alert-box.radius {
            border-radius: 3px;
        }

        .alert-box {
            background-color: #008cba;
            border-color: #0078a0;
            border-style: solid;
            border-width: 1px;
            color: #ffffff;
            display: block;
            font-size: 0.72222rem;
            font-weight: normal;
            margin-bottom: 1.11111rem;
            padding: 0.77778rem 1.33333rem 0.77778rem 0.77778rem;
            position: relative;
            transition: opacity 300ms ease-out 0s;
        }

            .alert-box.info {
                color: #4f4f4f;
            }

        .alert-box {
            color: #ffffff;
            font-size: 0.72222rem;
            font-weight: normal;
        }

        .tablets {
            width: 100% !important;
            /*max-width: 997px !important;*/
        }

        .caption {
            text-align: right !important;
        }

        .control {
            text-align: center;
        }

        .chk {
            margin: 0 !important;
        }

        #chkchilds {
            margin: 0 !important;
        }

        thead th,
        tbody td {
            padding: 4px !important;
        }

        .paragraph {
            font-size: 16px !important;
            color: #000;
        }

        .details {
            margin: 0 30px !important;
            color: #000;
        }

        .msg-error {
            margin-bottom: 20px;
            border-radius: 2px;
            border: 1px solid #dd7b74;
        }

        .data {
            width: 300px;
        }
    </style>
</asp:Content>

<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <%--  Form  --%>
    <div class="row">
        <div class="medium-12 columns">
            <h3><i class="step fi-align-justify size-29"></i>&nbsp;Select Tables to Process</h3>
        </div>

        <%-- Information --%>
        <div class="medium-12 columns">
            <div class="alert-box info radius">
                <p class="paragraph">In this step choose those tables that you want to process.</p>
                <ul class="details">
                    <li>SERVER: <strong><%= _property.SERVER_NAME %></strong></li>
                    <li>DATA BASE: <strong><%= _property.DATABASE %></strong></li>
                    <li>CONECCTION STRING: <strong><%= _property.CONNECTION_STRING %></strong></li>
                </ul>
            </div>
        </div>

        <%-- Error Message --%>
        <div class="medium-12 columns">
            <asp:ValidationSummary
                ID="Summary"
                runat="server"
                HeaderText="Error(es):"
                CssClass="msg-error" />
        </div>

        <%-- Button --%>
        <div class="medium-12 columns">
            <a href="<%: Page.GetRouteUrl("Generator-Connection", null )  %>" class="button alert hollow">Back</a>
            <asp:Button runat="server" ID="btnContinueTop" CssClass="button" Text="Continue" OnClick="BtnContinue_Click" />
        </div>

        <asp:ScriptManager ID="sm" runat="server" />
        <asp:UpdatePanel ID="up" runat="server" ChildrenAsTriggers="true">
            <ContentTemplate>
                <div class="medium-12 columns">
                    <table role="grid" class="tablets">
                        <thead>
                            <tr>
                                <th width="40" class="control">
                                    <asp:CheckBox
                                        runat="server"
                                        ID="chkfather"
                                        CssClass="chk"
                                        AutoPostBack="true"
                                        OnCheckedChanged="Chk_father_CheckedChanged" /></th>
                                <th>NAME</th>
                                <th class="data">SCHEMA NAME</th>
                                <th class="data">TABLE NAME</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="rpRegistros" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td width="40" class="control">
                                            <asp:CheckBox
                                                runat="server"
                                                ID="chkchilds"
                                                CssClass="chk"
                                                AutoPostBack="true"
                                                Checked='<%# Eval("PROCESS") %>'
                                                ValidationGroup='<%# Eval("TABLE_NAME") %>'
                                                OnCheckedChanged="Chk_childs_CheckedChanged" /></td>
                                        <td><%#  Eval("NAME")%></script></td>
                                        <td class="data"><%# Eval("TABLE_SCHEMA") %></td>
                                        <td class="data"><%# Eval("TABLE_NAME") %></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>

                <asp:UpdateProgress ID="updateProgress" runat="server">
                    <ProgressTemplate>
                        <div id="progressBackgroundFilter"></div>
                        <div id="processMessage">
                            <img alt="Loading" src="/img/loader2.gif" />
                        </div>
                    </ProgressTemplate>
                </asp:UpdateProgress>

            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="chkfather" EventName="CheckedChanged" />
            </Triggers>
        </asp:UpdatePanel>

        <%-- Button --%>
        <div class="medium-12 columns">
            <a href="<%: Page.GetRouteUrl("Generator-Connection", null )  %>" class="button alert hollow">Back</a>
            <asp:Button runat="server" ID="btnContinueFooter" CssClass="button" Text="Continue" OnClick="BtnContinue_Click" />
        </div>
    </div>
</asp:Content>
