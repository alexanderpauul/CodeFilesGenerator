<%@ Page Title="" Language="C#" MasterPageFile="~/master/base.master" AutoEventWireup="true" CodeBehind="generator_download.aspx.cs" Inherits="alpaul_gls.SGI.generator.generator_download" %>

<asp:Content ID="head" ContentPlaceHolderID="head" runat="server">
    <style>
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

        .group {
            margin: 10px 0 !important;
        }

        button.success, .button.success {
            background-color: #43ac6a;
            border-color: #368a55;
            color: #ffffff;
        }
    </style>
</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <%--  Formulario  --%>
    <div class="row">
        <div class="medium-12 columns">
            <h3><i class="step fi-align-justify size-29"></i>&nbsp;Download Generated Package.</h3>
        </div>

        <%-- Information --%>
        <div class="medium-12 columns">
            <div class="alert-box info radius">
                <p class="paragraph">Process Completed, please click Download button to get your Package.</p>
                <ul class="details">
                    <li>SERVER: <strong><%= _property.SERVER_NAME %></strong></li>
                    <li>DATA BASE: <strong><%= _property.DATABASE %></strong></li>
                    <li>CONECCTION STRING: <strong><%= _property.CONNECTION_STRING %></strong></li>
                </ul>

                <br />
                <div class="row">
                    <div class="medium-12 columns">
                        <a href="<%: Page.GetRouteUrl("Generator-Process", null )  %>" class="button alert hollow">Back</a>              
                        <asp:Button runat="server" ID="btnDownload" Text="Download" OnClick="BtnDownload_Click" CssClass="button success" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
