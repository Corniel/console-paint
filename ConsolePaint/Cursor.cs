using System;

namespace ConsolePaint
{
    /// <summary>Represents the position of the <see cref="Cursor"/> of the console.</summary>
    public readonly struct Cursor : IEquatable<Cursor>
    {
        public Cursor(short ln, short col)
        {
            Line = ln;
            Col = col;
        }

        /// <summary>Get the <see cref="Cursor"/> pointing to the left top.</summary>
        public static readonly Cursor LeftTop;

        /// <summary>Gets the line of the <see cref="string"/>.</summary>
        public short Line { get; }

        /// <summary>Gets the column of the <see cref="string"/>.</summary>
        public short Col { get; }

        /// <summary>Applies a carriage return <see cref="char"/> to the <see cref="Cursor"/>.</summary>
        public Cursor CarriageReturn() => new Cursor(Line, 0);

        /// <summary>Applies a new line <see cref="char"/> to the <see cref="Cursor"/>.</summary>
        public Cursor NewLine() => new Cursor((short)(Line + 1), 0);

        /// <inheritdoc/>
        public override bool Equals(object obj) => obj is Cursor other && Equals(other);

        /// <inheritdoc/>
        public bool Equals(Cursor other)
        {
            return Line == other.Line
                && Col == other.Col;
        }
        
        /// <inheritdoc/>
        public override int GetHashCode() => (Line << 16) | (int)Col;

        /// <summary>Represents the <see cref="Cursor"/> as a <see cref="string"/>.</summary>
        public override string ToString() => $"Ln: {Line}, Col: {Col}";
    }
}
