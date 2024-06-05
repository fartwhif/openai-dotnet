// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.FineTuning
{
    internal readonly partial struct InternalCreateFineTuningJobRequestIntegrationType : IEquatable<InternalCreateFineTuningJobRequestIntegrationType>
    {
        private readonly string _value;

        public InternalCreateFineTuningJobRequestIntegrationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WandbValue = "wandb";

        public static InternalCreateFineTuningJobRequestIntegrationType Wandb { get; } = new InternalCreateFineTuningJobRequestIntegrationType(WandbValue);
        public static bool operator ==(InternalCreateFineTuningJobRequestIntegrationType left, InternalCreateFineTuningJobRequestIntegrationType right) => left.Equals(right);
        public static bool operator !=(InternalCreateFineTuningJobRequestIntegrationType left, InternalCreateFineTuningJobRequestIntegrationType right) => !left.Equals(right);
        public static implicit operator InternalCreateFineTuningJobRequestIntegrationType(string value) => new InternalCreateFineTuningJobRequestIntegrationType(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalCreateFineTuningJobRequestIntegrationType other && Equals(other);
        public bool Equals(InternalCreateFineTuningJobRequestIntegrationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        public override string ToString() => _value;
    }
}