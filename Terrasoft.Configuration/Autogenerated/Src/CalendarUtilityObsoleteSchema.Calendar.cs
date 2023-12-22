namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarUtilityObsoleteSchema

	/// <exclude/>
	public class CalendarUtilityObsoleteSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarUtilityObsoleteSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarUtilityObsoleteSchema(CalendarUtilityObsoleteSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4e3cb340-4d0d-4fe9-b58a-97330a7996b4");
			Name = "CalendarUtilityObsolete";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,82,77,75,195,64,20,60,183,208,255,240,104,47,21,36,185,107,12,104,4,233,73,65,123,18,15,175,155,215,186,176,217,13,251,33,132,226,127,119,179,249,78,189,120,49,167,204,228,205,236,188,201,74,44,200,148,200,8,222,72,107,52,234,104,163,76,201,35,63,57,141,150,43,25,101,40,72,230,168,205,106,121,94,45,23,206,112,121,130,215,202,88,42,110,123,60,22,107,242,188,255,178,209,116,242,6,144,9,52,6,110,160,51,218,91,46,184,173,194,76,28,199,144,24,87,20,168,171,180,197,247,192,130,194,126,162,133,82,171,47,158,147,1,214,170,193,242,130,106,196,156,8,1,193,5,63,78,38,234,12,227,145,99,233,14,130,51,40,81,91,142,162,181,158,69,185,12,247,128,134,188,248,28,66,14,155,40,105,172,118,204,42,93,47,244,18,172,155,145,249,34,129,200,52,161,37,192,33,124,147,181,138,122,73,60,215,36,62,41,22,32,253,127,185,91,119,186,93,190,78,187,132,224,235,144,150,31,57,233,40,137,195,244,239,98,103,72,251,196,146,88,93,211,58,221,123,12,172,39,38,226,247,231,131,81,130,44,125,212,168,237,108,214,201,246,201,241,28,134,72,215,176,159,156,0,211,3,175,124,67,7,95,227,118,172,152,143,212,55,106,241,253,31,21,14,5,254,125,241,93,71,36,253,219,35,86,105,159,233,98,213,233,98,27,207,53,55,40,224,134,157,146,158,27,63,63,245,114,71,146,150,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4e3cb340-4d0d-4fe9-b58a-97330a7996b4"));
		}

		#endregion

	}

	#endregion

}

