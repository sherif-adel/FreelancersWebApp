<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ManageProfile.ascx.cs" Inherits="FreeLancers.UI.Freelancer.ManageProfile" %>

<script>
    var count = 1;
    function ShowMoreImages() {
        debugger;
        if (count < 4) {
            $("#divImage" + count).show(1000);
            count++;
        }
        else {
            this.visible = false;
        }
    }
</script>
<div>
     <div>
        <asp:Label ID="lblCompanyName" runat="server" Text="Company Name:"></asp:Label>
        <asp:TextBox ID="txtCompanyName" runat="server" TextMode="MultiLine"></asp:TextBox>
    </div>
    <div>
        <asp:Label runat="server" Text="Description:"></asp:Label>
        <asp:TextBox runat="server" TextMode="MultiLine"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblExperience" runat="server" Text="Experience:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Range"></asp:TextBox>
    </div>
     <div>
        <asp:Label ID="lblPreviousWork" runat="server" Text="Previous Work:"></asp:Label>
        <asp:TextBox ID="txtPreviousWork" runat="server" TextMode="MultiLine"></asp:TextBox>
    </div>
     <div>
        <asp:CheckBox ID="cbFeatures" runat="server" Enabled="false" Text="Featured" TextAlign="Left" />
    </div>
    <div>
        <asp:Label ID="lblYouTubeURL" runat="server" Text="YouTube Video URL:"></asp:Label>
        <asp:TextBox ID="txtYouTubeURL" runat="server" TextMode="MultiLine"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblLinkedInURL" runat="server" Text="LinkedIn Profile URL:"></asp:Label>
        <asp:TextBox ID="txtLinkedInURL" runat="server" TextMode="MultiLine"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblImage1" runat="server" Text="Image 1:"></asp:Label>
        <asp:FileUpload runat="server" ID="fileImage1"/>
    </div>
     <div id="divImage2" style="visibility:hidden">
        <asp:Label ID="lblImage2" runat="server" Text="Image 2:"></asp:Label>
        <asp:FileUpload runat="server" ID="fileImage2"/>
    </div>
     <div id="divImage3" style="visibility:hidden">
        <asp:Label ID="lblImage3" runat="server" Text="Image 3:"></asp:Label>
        <asp:FileUpload runat="server" ID="fileImage3"/>
    </div>
    <button id="btnMoreImages" onclick="ShowMoreImages()" >More Images</button>
</div>