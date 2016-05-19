# WindowsForm
Para este projeto eu utilizei o ADO.NET conectando em um servidor remoto - SQL Server. Para testar como outro servidor ou maquina local
alterar o connectionstring do arquivo App.config.
<connectionStrings>
    <add name="DbTesteEntities" connectionString="metadata=res://*/Cli_Model.csdl|res://*/Cli_Model.ssdl|res://*/Cli_Model.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=<nome do Servidor ou IP>;initial catalog=DbTeste;user id=sa;password=*****;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
</connectionStrings>
