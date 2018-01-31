﻿namespace Musoq.Parser.Nodes
{
    public class ModuloNode : BinaryNode
    {
        public ModuloNode(Node left, Node right) 
            : base(left, right)
        {
            Id = CalculateId(this);
        }
        public override void Accept(IExpressionVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string Id { get; }

        public override string ToString()
        {
            return $"{Left.ToString()} % {Right.ToString()}";
        }
    }
}