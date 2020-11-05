<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html"/>
	<xsl:template match="/">
		<html>
			<body>
				<style>
					* {
					margin: 0;
					padding: 0;
					}
					table {
					margin-top: 5%;
					margin-left: auto;
					margin-right: auto;
					color: black;
					}

					th {
					font-weight: bold;
					}

					tr:hover {
					color: black;
					background-color: lightgrey;
					}

					#wrapper {
					width: 100%;
					position: absolute;
					color: white;
					}

					#table-color {
					color: white;
					}

					#stars {
					background: #09121f;
					width: 100%;
					-webkit-transition: all 0.4s ease-in-out;
					-moz-transition: all 0.4s ease-in-out;
					-ms-transition: all 0.4s ease-in-out;
					-o-transition: all 0.4s ease-in-out;
					transition: all 0.4s ease-in-out;
					}

					#stars:hover {
					background: #0c1b2e;
					}
				</style>

				<div id="wrapper">
					<h1>PhonesDataBase by The Grassman's</h1>

					<table id="table-color" border="1" width="1200">
						<tr>
							<th>Brand</th>
							<th>Year</th>
							<th>Size</th>
							<th>Memory</th>
							<th>Price</th>
							<th>Color</th>
						</tr>
						<xsl:for-each select="Phones/Phone">
							<tr>
								<td>
									<xsl:value-of select="@Brand"/>
								</td>
								<td>
									<xsl:value-of select="@Year"/>
								</td>
								<td>
									<xsl:value-of select="@Size"/>
								</td>
								<td>
									<xsl:value-of select="@Memory"/>
								</td>
								<td>
									<xsl:value-of select="@Price"/>
								</td>
								<td>
									<xsl:value-of select="@Color"/>
								</td>
							</tr>
						</xsl:for-each>
					</table>
				</div>
				<canvas id="stars">
				</canvas>
				<script src="http://atuin.ru/js/art/stars.js" type="text/javascript"></script>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>