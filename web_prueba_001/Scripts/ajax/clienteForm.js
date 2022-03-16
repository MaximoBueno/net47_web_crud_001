

$(document).ready(function () {


   
        $("#form_id_nuevo_cliente").submit(function (event) {

            event.preventDefault();

            let mi_data = $(this).serialize();

           
            $.ajax({
                    url: '../../Api/Cliente/guardar/',
                    method: "POST",
                    data: mi_data,
                    beforeSend: function () {
                        console.log("Antes del envio", mi_data);
                    },
                    success: function (data) {

                        console.log(data);

                        window.location.href = '/Cliente';
                    }
            });

        });

});