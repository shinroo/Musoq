﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Musoq.Parser;
using Musoq.Parser.Nodes;
using Musoq.Schema;
using Musoq.Schema.DataSources;

namespace Musoq.Evaluator.Visitors
{
    public class SelectFieldsCollectVisitor : IExpressionVisitor
    {

        private readonly List<ISchemaColumn> _collectedFieldNames = new List<ISchemaColumn>();

        public ISchemaColumn[] CollectedFieldNames => _collectedFieldNames.ToArray();

        public void Visit(Node node)
        {
        }

        public void Visit(DescNode node)
        {
        }

        public void Visit(StarNode node)
        {
        }

        public void Visit(FSlashNode node)
        {
        }

        public void Visit(ModuloNode node)
        {
        }

        public void Visit(AddNode node)
        {
        }

        public void Visit(HyphenNode node)
        {
        }

        public void Visit(AndNode node)
        {
        }

        public void Visit(OrNode node)
        {
        }

        public void Visit(ShortCircuitingNodeLeft node)
        {
        }

        public void Visit(ShortCircuitingNodeRight node)
        {
        }

        public void Visit(EqualityNode node)
        {
        }

        public void Visit(GreaterOrEqualNode node)
        {
        }

        public void Visit(LessOrEqualNode node)
        {
        }

        public void Visit(GreaterNode node)
        {
        }

        public void Visit(LessNode node)
        {
        }

        public void Visit(DiffNode node)
        {
        }

        public void Visit(NotNode node)
        {
        }

        public void Visit(LikeNode node)
        {
        }

        public void Visit(FieldNode node)
        {
            if(_collectedFieldNames.All(field => field.ColumnName != node.FieldName))
                _collectedFieldNames.Add(new SchemaColumn(node.FieldName, _collectedFieldNames.Count, node.ReturnType));
        }

        public void Visit(StringNode node)
        {
        }

        public void Visit(DecimalNode node)
        {
        }

        public void Visit(IntegerNode node)
        {
        }

        public void Visit(WordNode node)
        {
        }

        public void Visit(ContainsNode node)
        {
        }

        public void Visit(AccessMethodNode node)
        {
        }

        public void Visit(GroupByAccessMethodNode node)
        {
        }

        public void Visit(AccessRefreshAggreationScoreNode node)
        {
        }

        public void Visit(AccessColumnNode node)
        {
        }

        public void Visit(AllColumnsNode node)
        {
        }

        public void Visit(IdentifierNode node)
        {
        }

        public void Visit(AccessObjectArrayNode node)
        {
        }

        public void Visit(AccessObjectKeyNode node)
        {
        }

        public void Visit(PropertyValueNode node)
        {
        }

        public void Visit(DotNode node)
        {
        }

        public void Visit(AccessCallChainNode node)
        {
        }

        public void Visit(ArgsListNode node)
        {
        }

        public void Visit(SelectNode node)
        {
        }

        public void Visit(GroupSelectNode node)
        {
        }

        public void Visit(WhereNode node)
        {
        }

        public void Visit(GroupByNode node)
        {
        }

        public void Visit(HavingNode node)
        {
        }

        public void Visit(SkipNode node)
        {
        }

        public void Visit(TakeNode node)
        {
        }

        public void Visit(JoinInMemoryWithSourceTableFromNode node)
        {
        }

        public void Visit(SchemaFromNode node)
        {
        }

        public void Visit(JoinSourcesTableFromNode node)
        {
        }

        public void Visit(InMemoryTableFromNode node)
        {
        }

        public void Visit(JoinFromNode node)
        {
        }

        public void Visit(ExpressionFromNode node)
        {
        }

        public void Visit(CreateTableNode node)
        {
        }

        public void Visit(RenameTableNode node)
        {
        }

        public void Visit(TranslatedSetTreeNode node)
        {
        }

        public void Visit(IntoNode node)
        {
        }

        public void Visit(QueryScope node)
        {
        }

        public void Visit(ShouldBePresentInTheTable node)
        {
        }

        public void Visit(TranslatedSetOperatorNode node)
        {
        }

        public void Visit(QueryNode node)
        {
        }

        public void Visit(InternalQueryNode node)
        {
        }

        public void Visit(RootNode node)
        {
        }

        public void Visit(SingleSetNode node)
        {
        }

        public void Visit(UnionNode node)
        {
        }

        public void Visit(UnionAllNode node)
        {
        }

        public void Visit(ExceptNode node)
        {
        }

        public void Visit(RefreshNode node)
        {
        }

        public void Visit(IntersectNode node)
        {
        }

        public void Visit(PutTrueNode node)
        {
        }

        public void Visit(MultiStatementNode node)
        {
        }

        public void Visit(CteExpressionNode node)
        {
        }

        public void Visit(CteInnerExpressionNode node)
        {
        }

        public void Visit(JoinsNode node)
        {
        }

        public void Visit(JoinNode node)
        {
        }
    }
}