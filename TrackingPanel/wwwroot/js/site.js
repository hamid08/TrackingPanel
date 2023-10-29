function init() {
    var map = L.map('map', {
        center: [52.0, -11.0],
        zoom: 5,
        layers: [
            L.tileLayer('http://map.separta.ir/tile/{z}/{x}/{y}.png', {
                attribution: '&copy; <a href="http://osm.org/copyright">OpenStreetMap</a> contributors'
            })
        ]
    });

    // --- Example with an array of Polylines ---

    var multiCoords1 = [
       
        [
            ////1
            [35.585718, 51.364908],
            [35.584601, 51.363996],
            [35.585255, 51.362183],
            [35.586084, 51.362773],
            [35.585735, 51.364082],

            ////2
            //[35.585456, 51.364317],
            //[35.585452, 51.364311],
            //[35.585461, 51.364279],
            //[35.585478, 51.364295],
            [35.585557571428566, 51.36367371428571]

        ],
    ];
    var plArray = [];
    for (var i = 0; i < multiCoords1.length; i++) {
        plArray.push(L.polyline(multiCoords1[i], { color: 'green', weight: 3, opacity: 1, smoothFactor: 1 }).addTo(map));
    }


    var polyline = L.polylineDecorator(multiCoords1, {
        patterns: [
            { offset: 25, repeat: 50, symbol: L.Symbol.arrowHead({ pixelSize: 15, pathOptions: { fillOpacity: 1, weight: 0, color: 'red' } }) }
        ]
    }).addTo(map);

    map.fitBounds(polyline.getBounds());

    var circle = L.circle([35.585557571428566, 51.36367371428571], {
        color: 'red',
        fillColor: '#f03',
        fillOpacity: 0.5,
        radius: 10
            //0.022753039271375855
    }).addTo(map);



}