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

    if (endpoints) {

        config.columns.push({
            data: "Id",
            className: "text-center td-actions",
            sortable: false,
            render: function(data, type, row, meta) {
                var actions = "";

                if (endpoints.details)
                    actions += '<a href="' +
                        endpoints.details +
                        "/" +
                        data +
                        '"> <i class="fa fa-search text-navy"></i></a>';

                if (endpoints.edit)
                    actions += '<a href="' +
                        endpoints.edit +
                        "/" +
                        data +
                        '"><i class="fa fa-pencil-alt text-warning"></i></a>';

                if (endpoints.delete)
                    actions += '<a href="' +
                        endpoints.delete +
                        "/" +
                        data +
                        '"><i class="fa fa-trash-alt text-danger"></i></a>';

                if (endpoints.giveback)
                    actions += '<a href="' +
                        endpoints.giveback +
                        "/" +
                        data +
                        '"><i class="fa fa-undo-alt text-navy"></i></a>';

                return actions;
            }

        });
    }


    return config;
}