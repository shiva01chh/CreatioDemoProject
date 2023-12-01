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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,82,77,75,195,64,20,60,183,208,255,240,104,47,21,36,185,107,12,104,4,233,73,65,123,18,15,175,155,151,186,176,217,13,251,33,132,226,127,119,179,249,106,82,47,94,204,41,51,121,51,59,111,178,18,75,50,21,50,130,55,210,26,141,42,108,148,41,89,240,163,211,104,185,146,81,134,130,100,142,218,172,150,167,213,114,225,12,151,71,120,173,141,165,242,118,192,231,98,77,158,247,95,54,154,142,222,0,50,129,198,192,13,244,70,123,203,5,183,117,152,137,227,24,18,227,202,18,117,157,118,248,30,88,80,216,79,180,80,105,245,197,115,50,192,58,53,88,94,82,131,152,19,33,32,184,224,199,201,68,189,97,124,230,88,185,131,224,12,42,212,150,163,232,172,103,81,46,195,61,160,33,47,62,133,144,227,38,74,26,171,29,179,74,55,11,189,4,235,118,100,190,72,32,50,77,104,9,112,12,223,102,173,163,65,18,207,53,137,79,138,37,72,255,95,238,214,189,110,151,175,211,62,33,248,58,164,229,5,39,29,37,113,152,254,93,236,12,105,159,88,18,107,106,90,167,123,143,129,13,196,68,252,254,124,48,74,144,165,143,6,117,157,205,58,217,62,57,158,195,24,233,26,246,147,19,96,122,224,149,111,232,224,107,220,158,43,230,35,205,141,90,124,255,71,133,99,129,127,95,124,215,19,201,240,246,136,117,58,100,186,88,117,186,216,198,115,237,13,10,184,101,167,164,231,252,243,3,183,189,91,183,141,3,0,0 };
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

