<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html"/>

    <xsl:template match="/">
      <html>
        <head>
          <title>Lê văn đại</title>
          <link rel="stylesheet" type="text/css" href="Stylesheet.css"></link>
        </head>
        <body>
          <div id="dsm">
            <h1>Danh Mục Sách</h1>
          </div>
          <xsl:for-each select="//CoSo">
            <div id ="khung">
              <h3>
                Cơ Sở :<xsl:value-of select="@TenCS"/>
              </h3>
              <xsl:for-each select="NhaXB">
                <h4>
                  Nhà Xuất Bản: <xsl:value-of select="TenNXB"/>
                </h4>
                <table border="2" align ="center" width="80%" cellspacing="0">
                  <tr>
                    <th>STT</th>
                    <th>Tên Sách</th>
                    <th>Số Trang</th>
                    <th>Giá</th>
                  </tr>
                  <xsl:for-each select="Sach">
                    <tr>
                      <td>
                        <xsl:value-of select="position()"/>
                      </td>
                      <td>
                        <xsl:value-of select="TenSach"/>
                      </td>
                      <td>
                        <xsl:value-of select="SoTrang"/>
                      </td>
                      <xsl:variable name="sotrang" select="SoTrang"></xsl:variable>
                      <td>
                        <xsl:value-of select="$sotrang*3000"/>
                      </td>
                    </tr>
                  </xsl:for-each>
                </table>
              </xsl:for-each>
            </div>
          </xsl:for-each>
        </body>
      </html>

    </xsl:template>
</xsl:stylesheet>
