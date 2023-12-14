namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NumberRUExpressionConveterSchema

	/// <exclude/>
	public class NumberRUExpressionConveterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NumberRUExpressionConveterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NumberRUExpressionConveterSchema(NumberRUExpressionConveterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d1467aa9-7149-4dab-9d97-0660599142d3");
			Name = "NumberRUExpressionConveter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("14a29563-3c13-443c-a7aa-8d0c90d831c2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,79,203,10,194,64,12,60,91,232,63,132,158,20,100,193,147,168,71,245,170,224,227,36,30,182,53,109,23,218,221,146,100,69,81,255,221,84,207,13,115,201,204,100,134,120,219,34,119,182,64,56,33,145,229,80,138,89,7,95,186,42,146,21,23,124,154,188,210,100,20,217,249,10,142,79,22,108,87,186,43,46,251,156,67,131,130,227,108,110,22,102,6,111,216,4,240,65,32,50,130,212,142,161,104,44,243,20,156,215,51,123,251,241,3,45,102,23,219,28,233,112,222,62,58,66,102,165,84,191,35,9,82,54,185,106,93,23,243,198,21,255,72,24,112,171,25,150,67,98,31,5,26,212,191,243,73,19,69,63,95,182,190,109,92,0,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d1467aa9-7149-4dab-9d97-0660599142d3"));
		}

		#endregion

	}

	#endregion

}

