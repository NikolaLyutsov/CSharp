<!Doctype html>
<html>
<head>
    <meta charset="utf-8">
    <title>University grid</title>
    <style>
        table {
            width: 60%;
            margin-left: 3%;
            
            border-collapse: collapse;
            font-size: 20px;
        }
        table, tr, th, td {
            border: 1px groove;
            border: groove;
        }
        table tfoot td {
            padding: 10px;
        }
        .currentpage {
            color: orange;
        }
    </style>
</head>
<body>
        <table>
            <thead>
                <tr>
                    <th rowspan="2">Order</th>
                    <th colspan="3">Personal Info</th>
                    <th colspan="5">University Marks</th>
                </tr>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Faculty Number</th>

                    <th>English</th>
                    <th>Math</th>
                    <th>Biology</th>
                    <th>Physics</th>
                    <th>Total</th>
                </tr>
            </thead>
            <tbody>
                <tr id="row1">
                    <td>1</td>
                    <td>Stefan</td>
                    <td>Milanov</td>
                    <td>123456</td>
                    <td>2</td>
                    <td>3</td>
                    <td>4</td>
                    <td>5</td>
                    <td>3.50</td>
                </tr>
                <tr id="row2">
                    <td>2</td>
                    <td>Stefan</td>
                    <td>Milanov</td>
                    <td>123456</td>
                    <td>2</td>
                    <td>3</td>
                    <td>4</td>
                    <td>5</td>
                    <td>3.50</td>
                </tr>
                <tr id="row3">
                    <td>3</td>
                    <td>Stefan</td>
                    <td>Milanov</td>
                    <td>123456</td>
                    <td>2</td>
                    <td>3</td>
                    <td>4</td>
                    <td>5</td>
                    <td>3.50</td>
                </tr>
                <tr id="row4">
                    <td>4</td>
                    <td>Stefan</td>
                    <td>Milanov</td>
                    <td>123456</td>
                    <td>2</td>
                    <td>3</td>
                    <td>4</td>
                    <td>5</td>
                    <td>3.50</td>
                </tr>
                <tr id="row5">
                    <td>5</td>
                    <td>Stefan</td>
                    <td>Milanov</td>
                    <td>123456</td>
                    <td>2</td>
                    <td>3</td>
                    <td>4</td>
                    <td>5</td>
                    <td>3.50</td>
                </tr>
                <tr id="row6">
                    <td>6</td>
                    <td>Stefan</td>
                    <td>Milanov</td>
                    <td>123456</td>
                    <td>2</td>
                    <td>3</td>
                    <td>4</td>
                    <td>5</td>
                    <td>3.50</td>
                </tr>
                <tr id="row7">
                    <td>7</td>
                    <td>Stefan</td>
                    <td>Milanov</td>
                    <td>123456</td>
                    <td>2</td>
                    <td>3</td>
                    <td>4</td>
                    <td>5</td>
                    <td>3.50</td>
                </tr>
                <tr id="row8">
                    <td>8</td>
                    <td>Stefan</td>
                    <td>Milanov</td>
                    <td>123456</td>
                    <td>2</td>
                    <td>3</td>
                    <td>4</td>
                    <td>5</td>
                    <td>3.50</td>
                </tr>
                <tr id="row9">
                    <td>9</td>
                    <td>Stefan</td>
                    <td>Milanov</td>
                    <td>123456</td>
                    <td>2</td>
                    <td>3</td>
                    <td>4</td>
                    <td>5</td>
                    <td>3.50</td>
                </tr>
                <tr id="row10">
                    <td>10</td>
                    <td>Stefan</td>
                    <td>Milanov</td>
                    <td>123456</td>
                    <td>2</td>
                    <td>3</td>
                    <td>4</td>
                    <td>5</td>
                    <td>3.50</td>
                </tr>
            </tbody>
            <tfoot>
                <tr>
                    <td colspan="9">
                        <input type="button" name="previous" value="Previous"/>
                        <a class="currentpage" href="02.UniversityGrid.html">1</a>,
                        <a href="University marks/02.UniversityGrid(2).html">2</a>,
                        <a href="University marks/02.UniversityGrid(3).html">3</a>,
                        <a href="University marks/02.UniversityGrid(4).html">4</a>...,
                        <a href="University marks/02.UniversityGrid(10).html">10</a>
                        <a href="University marks/02.UniversityGrid(2).html">
                            <input type="button" name="next" value="Next" />
                        </a>
                    </td>
                </tr>
            </tfoot>
        </table>
</body>
</html>