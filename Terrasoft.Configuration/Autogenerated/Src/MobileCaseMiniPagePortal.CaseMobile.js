[
  {
    "operation": "insert",
    "name": "Root",
    "values": {"navigationConfig": {}, "viewConfig": {}, "actions": {}, "controllers": {}}
  },
  {
    "operation": "insert",
    "name": "NavigationConfig",
    "values": {"showCloseDialog": true},
    "parentName": "Root",
    "propertyName": "navigationConfig",
    "index": 0
  },
  {
    "operation": "insert",
    "name": "ViewConfig",
    "values": {"type": "AddScreen", "title": "#ResourceString(NewCase)", "editCard": {}},
    "parentName": "Root",
    "propertyName": "viewConfig",
    "index": 1
  },
  {
    "operation": "insert",
    "name": "CaseAddCard",
    "values": {"type": "CaseAddCard", "controller": "$Case", "body": {}},
    "parentName": "ViewConfig",
    "propertyName": "editCard",
    "index": 0
  },
  {
    "operation": "insert",
    "name": "CaseAddCardBody",
    "values": {"type": "Column", "scrollable": true, "items": []},
    "parentName": "CaseAddCard",
    "propertyName": "body",
    "index": 0
  },
  {
    "operation": "insert",
    "name": "CaseAddCardCategory",
    "values": {"type": "EditField", "properties": {"value": "$Category"}},
    "parentName": "CaseAddCardBody",
    "propertyName": "items",
    "index": 0
  },
  {
    "operation": "insert",
    "name": "CaseAddCardSymptoms",
    "values": {
      "type": "EditField",
      "properties": {"value": "$Symptoms", "hint": "#ResourceString(SymptomsHint)", "minLines": 5}
    },
    "parentName": "CaseAddCardBody",
    "propertyName": "items",
    "index": 1
  },
  {
    "operation": "insert",
    "name": "Actions",
    "values": {"onSave": {}, "onCancel": {}},
    "parentName": "Root",
    "propertyName": "actions",
    "index": 2
  },
  {
    "operation": "insert",
    "name": "SaveAction",
    "values": {"type": "ControllerEvent", "controllerName": "Case", "event": "Save"},
    "parentName": "Actions",
    "propertyName": "onSave",
    "index": 0
  },
  {
    "operation": "insert",
    "name": "CancelAction",
    "values": {"type": "ControllerEvent", "controllerName": "Case", "event": "Cancel"},
    "parentName": "Actions",
    "propertyName": "onCancel",
    "index": 1
  },
  {
    "operation": "insert",
    "name": "Controllers",
    "values": {"Case": {}},
    "parentName": "Root",
    "propertyName": "controllers",
    "index": 3
  },
  {
    "operation": "insert",
    "name": "CaseController",
    "values": {"type": "CaseAddCardController", "model": {}, "businessRules": {}},
    "parentName": "Controllers",
    "propertyName": "Case",
    "index": 0
  },
  {
    "operation": "insert",
    "name": "CaseModel",
    "values": {"type": "CaseEntityModel", "entityName": "Case", "id": "recordId", "columns": []},
    "parentName": "CaseController",
    "propertyName": "model",
    "index": 0
  },
  {
    "operation": "insert",
    "name": "CaseModelIdColumn",
    "values": {"expression": {"columnPath": "Id", "expressionType": 0}},
    "parentName": "CaseModel",
    "propertyName": "columns",
    "index": 0
  },
  {
    "operation": "insert",
    "name": "CaseModelCategoryColumn",
    "values": {"expression": {"columnPath": "Category", "expressionType": 0}},
    "parentName": "CaseModel",
    "propertyName": "columns",
    "index": 1
  },
  {
    "operation": "insert",
    "name": "CaseModelSymptomsColumn",
    "values": {"expression": {"columnPath": "Symptoms", "expressionType": 0}},
    "parentName": "CaseModel",
    "propertyName": "columns",
    "index": 2
  },
  {
    "operation": "insert",
    "name": "CaseBusinessRules",
    "values": {"Category": {}},
    "parentName": "CaseController",
    "propertyName": "businessRules",
    "index": 1
  },
  {
    "operation": "insert",
    "name": "CaseBusinessRuleCategory",
    "values": {
      "CategoryRequirementRule": {
        "uId": "d3993817-f2e8-4b14-8616-e6eeefd25f1a",
        "enabled": true,
        "removed": false,
        "ruleType": 0,
        "property": 2,
        "logical": 1,
        "conditions": [
          {
            "comparisonType": 3,
            "leftExpression": {"type": 1, "attribute": "Category"},
            "rightExpression": {"type": 0, "value": null, "dataValueType": 1}
          }
        ]
      }
    },
    "parentName": "CaseBusinessRules",
    "propertyName": "Category",
    "index": 0
  }
]