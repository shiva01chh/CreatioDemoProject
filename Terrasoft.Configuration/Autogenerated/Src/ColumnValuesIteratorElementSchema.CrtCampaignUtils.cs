namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnValuesIteratorElementSchema

	/// <exclude/>
	public class ColumnValuesIteratorElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnValuesIteratorElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnValuesIteratorElementSchema(ColumnValuesIteratorElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("940b6f42-9d5c-4d59-8253-b8b8e250727e");
			Name = "ColumnValuesIteratorElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,77,79,195,48,12,134,207,171,180,255,96,149,11,92,154,59,116,149,80,197,129,195,164,29,16,119,47,117,187,136,38,169,226,116,128,16,255,157,52,105,39,168,38,114,138,191,30,219,175,13,106,226,1,37,193,11,57,135,108,91,95,212,214,180,170,27,29,122,101,77,81,163,30,80,117,134,183,217,215,54,219,102,155,27,71,93,8,64,221,35,243,61,212,182,31,181,121,197,126,36,126,246,20,170,172,123,234,73,147,241,49,93,8,1,37,143,90,163,251,172,102,251,241,200,222,161,244,64,41,17,90,235,66,18,17,72,71,237,46,191,198,204,69,85,44,56,241,139,55,140,199,94,73,192,5,41,167,177,254,159,106,147,22,185,108,178,39,127,178,77,216,229,16,89,41,184,158,59,58,246,248,70,12,161,205,84,246,174,252,9,52,74,103,25,206,177,19,160,105,64,198,214,179,167,184,160,196,154,85,14,232,80,131,9,23,216,229,210,26,79,31,62,175,234,244,137,138,12,206,74,98,86,166,91,132,226,162,20,177,44,82,214,171,159,173,106,224,144,138,110,175,41,176,192,231,110,119,15,179,14,100,154,36,69,180,191,211,153,255,56,131,111,122,63,198,79,40,182,47,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("940b6f42-9d5c-4d59-8253-b8b8e250727e"));
		}

		#endregion

	}

	#endregion

}

