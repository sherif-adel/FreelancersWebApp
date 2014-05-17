<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyProfile.aspx.cs" MasterPageFile="~/Freelancer/Freelancer.Master" Inherits="FreeLancers.UI.Freelancer.MyProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <legend>Edit Personal Profile
    </legend>
    <form role="form">
        <div class="form-group">
            <label for="txtCompanyName">Company Name (Optional)</label>
            <input type="text" class="form-control" id="txtCompanyName" runat="server" placeholder="Enter Company Name">
        </div>
        <div id="image1Div" class="form-group">
            <label for="image1">Image 1</label>
            <input type="file" id="image1Upload" runat="server">
            <img id="image1" runat="server" visible="false" />
        </div>
        <div id="image2Div" style="display: none;" class="form-group">
            <label for="image2">Image 2</label>
            <input type="file" id="image2Upload" runat="server">
            <img id="image2" runat="server" visible="false" />
        </div>
        <div id="image3Div" style="display: none;" class="form-group">
            <label for="image3">Image 3</label>
            <input type="file" id="image3Upload" runat="server">
            <img id="image3" runat="server" visible="false" />
        </div>
        <div class="form-group">
            <button type="button" onclick="ShowMoreImages(this)" class="btn btn-default">Add More Images</button>
        </div>
        <div class="form-group">
            <label for="txtDescription">Description</label>
            <textarea class="form-control" id="txtDescription" runat="server" placeholder="Description" required="required"></textarea>
        </div>

        <div class="form-group">
            <label for="txtPreviousWork">Previous Work</label>
            <textarea class="form-control" id="txtPreviousWork" runat="server" placeholder="Previous Work" required="required"></textarea>
        </div>
        <div class="form-group">
            <label for="txtExperience">Experience</label>
            <input type="range" class="form-control" min="0" max="30" value="0" id="experienceRange" step="0.5" runat="server" onchange="outputUpdate(value)">
            <input type="number" class="form-control" id="txtExperience" runat="server" placeholder="Experience" max="30" min="0" step="0.5" onchange="rangeUpdate(value)" required="required">
            <script>
                function outputUpdate(number) {
                    $('<%:txtExperience.ClientID%>').value = number;
                }

                function rangeUpdate(number) {
                    $('<%:experienceRange.ClientID%>').value = number;
                }
            </script>
        </div>
        <div class="form-group">
            <label for="txtLinkedInUrl">LinkedIn Url</label>
            <input type="url" class="form-control" id="txtLinkedInUrl" runat="server" placeholder="LinkedIn Url">
        </div>
        <div class="form-group">
            <label for="txtYouTubeUrl">YouTube Url</label>
            <input type="url" class="form-control" id="txtYouTubeUrl" runat="server" placeholder="YouTube Url">
        </div>
        <br />
        <div class="form-group  row">
            <div class="col-lg-6">
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" class="btn " />
            </div>
            <div class="col-lg-6">
                <asp:Button ID="btnEditProfile" runat="server" Text="Save Changes" class="btn green pull-right" OnClick="btnEditProfile_Click" />
            </div>
        </div>
        <br />
    </form>

    <script src="../Scripts/jquery-2.1.0.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            setActiveTab();
        });

        function setActiveTab() {
            var tab = $("#profile");
            tab.addClass('active');
            tab.children("a").append("<span class='selected'></span>");
        }

        var count = 2;
        function ShowMoreImages(button) {
            var imageDiv = $("#image" + count + "Div");
            imageDiv.show(200);
            count++;
            if (count == 4) {
                $(button).hide(100);
            }
        }
    </script>

</asp:Content>

