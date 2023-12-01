namespace Terrasoft.Configuration.ForecastV2
{
	using System.Collections.Generic;
	using Terrasoft.Configuration.ExportToExcel;

	/// <summary>
	/// Interface for exporting forecast history drilldown data to excel.
	/// </summary>
	public interface IForecastExportToExcelService
	{

		/// <summary>
		/// Creates and writes excel stream to local storage and return export key.
		/// </summary>
		/// <param name="filterConfig">Filter data configuration.</param>
		/// <param name="objectValueRecords">Object value records, which will be exported.</param>
		/// <returns><see cref="ExportToExcelResponse"/>Export response.</returns>
		ExportToExcelResponse GetExportToExcelKey(FilterConfig filterConfig, IEnumerable<ObjectValueRecord> objectValueRecords);
	}
} 




