function createSelect2Configuration(placeholder, endpoint, propertyId, propertyText) {


    var configuration = {
        allowClear: true,
        minimumInputLength: 0,
        placeholder: placeholder,
        ajax: {
            url: endpoint,
            dataType: 'json',
            delay: 500,
            data: function (params) {
                return {
                    term: params.term,
                    page: params.page
                };
            },
            processResults: function (data, params) {
                params.page = params.page || 1;
                var result = $.map(data.result,
                    function (obj) {
                        obj.id = obj.id || obj[propertyId];
                        obj.text = obj.text || obj[propertyText];
                        return obj;
                    });

                return {
                    results: result,
                    pagination: {
                        more: (params.page * 20) < data.total_count
                    }
                };
            }
        }
    }

    return configuration;
}