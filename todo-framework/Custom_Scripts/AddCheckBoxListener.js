$(document).ready(function () {

    $('.ActiveCheck').change(function () {
        let self = $(this);
        let id = self.attr('id');
        let value = self.prop('checked');

        $.ajax({
            url: '/Todoes/AJAXEdit',
            data: {
                id: id,
                value: value
            },
            type: 'POST',
            success: function (result) {
                $("#tableDiv").html(result);
            }
        });
    });

});