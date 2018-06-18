function CreateDataTableConfiguration(language, endpoints, filters, columns) {
    var config = {
        serverSide: true,
        searching: false,
        processing: true,

        pageLength: 10,

        language: translate[language],

        ajax: {
            url: endpoints.dataSrc,
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
            var element =
                '<a href="'+endpoints.details+'/'+data+
                '"> <i class="fa fa-search text-navy"></i> </a><a href="' + endpoints.edit + '/' + data +
                '"><i class="fa fa-pencil-alt text-warning"></i></a><a href="' + endpoints.delete + '/' + data +
                '"><i class="fa fa-trash-alt text-danger"></i></a>';;

            return element;
        }

    });

    return config;
}