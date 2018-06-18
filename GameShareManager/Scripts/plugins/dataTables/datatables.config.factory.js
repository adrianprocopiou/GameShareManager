function CreateDataTableConfiguration(language, endpoint, filters, columns) {
    var config = {
        serverSide: true,
        searching: false,
        processing: true,

        pageLength: 10,

        language: translate[language],

        ajax: {
            url: endpoint,
            data: function(d) {
                for (var filter in filters) {
                    if (filters.hasOwnProperty(filter)) {
                        d[filter] = filters[filter].val();
                    }
                }
            }
        },

        columns: columns
    };

    config.columns.push({
        data: "Id",
        className: "text-center td-actions",
        sortable: false,
        render: function(data, type, row, meta) {
            var element = '<a href="Details/' +
                data +
                '"> <i class="fa fa-search text-navy"></i> </a><a href="Edit/' +
                data +
                '"><i class="fa fa-pencil-alt text-warning"></i></a><a href="Delete/' +
                data +
                '"><i class="fa fa-trash-alt text-danger"></i></a>';;

            return element;
        }

    });

    return config;
}