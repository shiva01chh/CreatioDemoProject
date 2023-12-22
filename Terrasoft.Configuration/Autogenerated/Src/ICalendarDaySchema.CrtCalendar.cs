namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICalendarDaySchema

	/// <exclude/>
	public class ICalendarDaySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICalendarDaySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICalendarDaySchema(ICalendarDaySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("19a08bf9-19ad-47db-8c56-e2bfbacbcbb5");
			Name = "ICalendarDay";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,83,177,106,195,48,16,157,19,200,63,104,108,23,123,111,130,151,4,130,161,180,67,29,50,203,214,57,136,200,146,123,39,53,152,210,127,239,201,177,155,16,234,197,198,131,116,247,222,189,167,59,201,202,6,168,149,21,136,2,16,37,185,218,39,91,103,107,125,10,40,189,118,54,217,74,3,86,73,164,213,242,123,181,92,4,210,246,36,62,58,242,208,172,31,246,204,52,6,170,72,163,100,15,22,80,87,140,97,84,27,74,163,43,161,173,7,172,163,90,62,150,221,201,78,188,240,214,56,11,178,52,192,224,40,179,72,211,84,108,40,52,141,196,46,27,3,17,236,106,113,1,56,39,127,160,244,30,197,136,247,250,200,121,113,91,245,245,22,39,240,235,126,65,195,226,167,119,246,191,208,232,78,40,233,161,208,13,76,202,93,211,226,118,156,33,48,67,244,205,89,113,113,120,142,13,85,124,210,22,93,11,232,187,9,237,210,57,35,114,98,214,113,32,205,208,28,169,62,122,238,199,243,37,13,77,40,190,106,242,155,129,145,15,216,76,60,4,104,142,141,131,213,159,129,13,40,176,94,215,26,48,142,57,246,192,119,237,84,239,247,65,171,56,229,130,33,135,92,205,145,221,131,239,85,46,119,93,152,80,235,35,8,62,160,165,108,247,192,217,164,99,38,66,149,227,219,14,177,248,208,154,120,33,158,158,175,47,129,237,240,127,255,253,2,172,92,102,103,131,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("19a08bf9-19ad-47db-8c56-e2bfbacbcbb5"));
		}

		#endregion

	}

	#endregion

}

