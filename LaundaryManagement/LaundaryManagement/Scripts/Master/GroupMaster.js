function AddGroupMaster() {
  //  jQuery.support.cors = true;
    //var groups = {
    //    //EmpID: $('#txtaddEmpid').val(),
    //    GroupName: $('#txtgname').val(),
    //    GroupCode: $('#txtgcode').val(),
    //    Status: $('#drpGroupStatus').val(),
    //    ColorCode: $('#txtgcolor').val(),
    //};
    GetGroupDetails();
    var URL = '/GroupMaster/Insert';
   
    $.ajax({
        type: "POST",
        url: URL,
        //dataType: 'json',
        data: { model: JSON.stringify(JsonGroupMaster) },
        success: function (msg) {

        }
    });
    }
//    $.ajax({
//        url: '@Url.Action("Insert", "GroupMaster")',
//        type: 'POST',
//        data: JSON.stringify(""),
//        contentType: "application/json;charset=utf-8",
//        beforeSend: function (request) {
//            request.setRequestHeader("Authorization-Token", $('.hddToken').val());
//        },
//        success: function (data) {
//            WriteResponse(data);
//        },
//        error: function (x, y, z) {
//            alert(x + '\n' + y + '\n' + z);
//        }
//    });
//}
var JsonGroupMaster = {
    "GroupName": null,
    "GroupCode": null,
    "Status": null,
    "ColorCode": null,
   
};
function GetGroupDetails() {
    JsonGroupMaster.GroupName = $('#txtgname').val();
    alert($('#txtgname').val());
    JsonGroupMaster.GroupCode = $('#txtgcode').val();
    JsonGroupMaster.Status = $('#drpGroupStatus').val();
    JsonGroupMaster.ColorCode = $('#txtgcolor').val();
}
  



//function AddwwGroupMaster() {
//    alert('00');
//    var name = $('#txtgname').val();
//    var address = $('#txtgcode').val();
//    var dob = $('#txtgcolor').val();
//    $.ajax({
//        url: "http://localhost:52761/api/groups",
//        type: "Post",
//        data: JSON.stringify([name, address, dob]), //{ Name: name, 
//        // Address: address, DOB: dob },
//        contentType: 'application/json; charset=utf-8',
//        success: function (data) { },
//        error: function () { alert('error'); }
//    });

//}