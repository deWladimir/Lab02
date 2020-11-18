<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html"></xsl:output>

	<xsl:template match="/">
		<html>
			<body>
				<table border = "5" bordercolor="grren">
					<TR>
						<th>Name</th>
						<th>Author</th>
						<th>Genre</th>
						<th>Page Amount</th>
						<th>Overwhelm</th>
						<th>Edition</th>
            <th>Price</th>
					</TR>
					<xsl:for-each select= "Books/Book">
						<tr>
							<td>
								<xsl:value-of select="@Name"/>
							</td>
							<td>
								<xsl:value-of select="@Author"/>
							</td>
							<td>
								<xsl:value-of select="@Genre"/>
							</td>
							<td>
								<xsl:value-of select="@PageAmount"/>
							</td>
							<td>
								<xsl:value-of select="@Overwhelm"/>
							</td>
							<td>
								<xsl:value-of select="@Edition"/>
							</td>
              <td>
                <xsl:value-of select="@Price"/>
              </td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
