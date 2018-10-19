<%@ Page Title="" Language="C#" MasterPageFile="~/master/base.master" AutoEventWireup="true" CodeBehind="generator_process.aspx.cs" Inherits="alpaul_gls.SGI.generator.generator_process" %>

<asp:Content ID="head" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .chk {
            font-size: 16px;
            margin: -10px 0;
        }

        .continue-left {
            margin-right: 0 !important;
            padding-right: 0 !important;
            text-align: right;
        }

        .continue-right {
            /*margin-left: 0 !important;*/
            /*padding-left: 0 !important;*/
        }

        .continue {
            text-align: right;
            margin-right: -15px !important;
            height: 2.4375rem;
        }

        .postfix {
            text-align: right;
        }

        .success {
            background-color: #43ac6a;
            border-color: #368a55;
            color: #ffffff;
        }

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

        .paragraph {
            font-size: 16px !important;
            color: #000;
        }

        .details {
            margin: 0 30px !important;
            color: #000;
        }
    </style>
</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <%--  Form  --%>
    <div class="row">
        <div class="medium-12 columns">
            <h3><i class="step fi-align-justify size-29"></i>&nbsp;Process</h3>
        </div>

        <%-- Information --%>
        <div class="medium-12 columns">
            <div class="alert-box info radius">
                <p class="paragraph">In this step choose those process that you want to make.</p>
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

        <div class="medium-12 columns">
            <fieldset>
                <legend>
                    <strong>Choose Process to Create</strong>
                </legend>
                <div class="callout secondary">
                    <div class="medium-6">
                        <div class="row">
                            <div class="small-3 columns"></div>
                            <div class="small-9 columns">
                                <label
                                    for="chkstoredprocedured"
                                    class="chk">
                                    <asp:CheckBox
                                        runat="server"
                                        ID="chkstoredprocedured"
                                        GroupName="Authentication" />
                                    Generate Stored Procedured.
                                </label>
                                <label
                                    for="chkentitieslayer"
                                    class="chk">
                                    <asp:CheckBox
                                        runat="server"
                                        ID="chkentitieslayer"
                                        GroupName="Authentication" />
                                    Generate Entities Layer.
                                </label>
                                <label
                                    for="chkdataleyer"
                                    class="chk">
                                    <asp:CheckBox
                                        runat="server"
                                        ID="chkdataleyer"
                                        GroupName="Authentication" />
                                    Generate Data Layer.                         
                                </label>
                                <label
                                    for="chkbusinesslayer"
                                    class="chk">
                                    <asp:CheckBox
                                        runat="server"
                                        ID="chkbusinesslayer"
                                        GroupName="Authentication" />
                                    Generate Business Layer.  
                                </label>
                                <label
                                    for="chksingelFile"
                                    class="chk">
                                    <asp:CheckBox
                                        runat="server"
                                        ID="chksingelFile"
                                        GroupName="Authentication" />
                                    Singel File.  
                                </label>
                            </div>
                        </div>

                        <br />
                        <div class="row">
                            <div class="small-3 columns">
                                <label
                                    for="txtPassword"
                                    class="middle text-right">
                                    Select Language
                                </label>
                            </div>
                            <div class="small-9 columns">
                                <asp:DropDownList
                                    runat="server"
                                    ID="ddlLanguage" />
                            </div>
                        </div>
                    </div>
                </div>

                <%-- Button --%>
                <div class="medium-12">
                    <a href="<%: Page.GetRouteUrl("Generator-Tables", null )  %>" class="button alert hollow">Back</a>
                    <asp:Button runat="server" ID="btnContinue" CssClass="button" Text="Continue" OnClick="BtnContinue_Click" />
                </div>

            </fieldset>
        </div>
    </div>
</asp:Content>
