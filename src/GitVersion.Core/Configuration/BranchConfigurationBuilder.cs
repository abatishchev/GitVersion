using GitVersion.VersionCalculation;

namespace GitVersion.Configuration;

public class BranchConfigurationBuilder
{
    public static BranchConfigurationBuilder New => new();

    private string name;
    private VersioningMode? versioningMode;
    private string? label;
    private IncrementStrategy? increment;
    private bool? preventIncrementOfMergedBranchVersion;
    private string? labelNumberPattern;
    private bool? trackMergeTarget;
    private bool? trackMergeMessage;
    private CommitMessageIncrementMode? commitMessageIncrementing;
    private string? regex;
    private HashSet<string>? sourceBranches;
    private HashSet<string>? isSourceBranchFor;
    private bool? tracksReleaseBranches;
    private bool? isReleaseBranch;
    private bool? isMainline;
    private int? preReleaseWeight;

    private BranchConfigurationBuilder()
    {
    }

    public virtual BranchConfigurationBuilder WithName(string value)
    {
        this.name = value;
        return this;
    }

    public virtual BranchConfigurationBuilder WithVersioningMode(VersioningMode? value)
    {
        this.versioningMode = value;
        return this;
    }

    public virtual BranchConfigurationBuilder WithLabel(string? value)
    {
        this.label = value;
        return this;
    }

    public virtual BranchConfigurationBuilder WithIncrement(IncrementStrategy? value)
    {
        this.increment = value;
        return this;
    }

    public virtual BranchConfigurationBuilder WithPreventIncrementOfMergedBranchVersion(bool? value)
    {
        this.preventIncrementOfMergedBranchVersion = value;
        return this;
    }

    public virtual BranchConfigurationBuilder WithLabelNumberPattern(string? value)
    {
        this.labelNumberPattern = value;
        return this;
    }

    public virtual BranchConfigurationBuilder WithTrackMergeTarget(bool? value)
    {
        this.trackMergeTarget = value;
        return this;
    }

    public virtual BranchConfigurationBuilder WithTrackMergeMessage(bool? value)
    {
        this.trackMergeMessage = value;
        return this;
    }

    public virtual BranchConfigurationBuilder WithCommitMessageIncrementing(CommitMessageIncrementMode? value)
    {
        this.commitMessageIncrementing = value;
        return this;
    }

    public virtual BranchConfigurationBuilder WithRegex(string? value)
    {
        this.regex = value;
        return this;
    }

    public virtual BranchConfigurationBuilder WithSourceBranches(IEnumerable<string>? values)
    {
        WithSourceBranches(values?.ToArray());
        return this;
    }

    public virtual BranchConfigurationBuilder WithSourceBranches(params string[]? values)
    {
        this.sourceBranches = values == null ? null : new HashSet<string>(values);
        return this;
    }

    public virtual BranchConfigurationBuilder WithIsSourceBranchFor(IEnumerable<string>? values)
    {
        WithIsSourceBranchFor(values?.ToArray());
        return this;
    }

    public virtual BranchConfigurationBuilder WithIsSourceBranchFor(params string[]? values)
    {
        this.isSourceBranchFor = values == null ? null : new HashSet<string>(values);
        return this;
    }

    public virtual BranchConfigurationBuilder WithTracksReleaseBranches(bool? value)
    {
        this.tracksReleaseBranches = value;
        return this;
    }

    public virtual BranchConfigurationBuilder WithIsReleaseBranch(bool? value)
    {
        this.isReleaseBranch = value;
        return this;
    }

    public virtual BranchConfigurationBuilder WithIsMainline(bool? value)
    {
        this.isMainline = value;
        return this;
    }

    public virtual BranchConfigurationBuilder WithPreReleaseWeight(int? value)
    {
        this.preReleaseWeight = value;
        return this;
    }

    public virtual BranchConfigurationBuilder WithConfiguration(BranchConfiguration value)
    {
        WithName(value.Name);
        WithVersioningMode(value.VersioningMode);
        WithLabel(value.Label);
        WithIncrement(value.Increment);
        WithPreventIncrementOfMergedBranchVersion(value.PreventIncrementOfMergedBranchVersion);
        WithLabelNumberPattern(value.LabelNumberPattern);
        WithTrackMergeTarget(value.TrackMergeTarget);
        WithTrackMergeMessage(value.TrackMergeMessage);
        WithCommitMessageIncrementing(value.CommitMessageIncrementing);
        WithRegex(value.Regex);
        WithTracksReleaseBranches(value.TracksReleaseBranches);
        WithIsReleaseBranch(value.IsReleaseBranch);
        WithIsMainline(value.IsMainline);
        WithPreReleaseWeight(value.PreReleaseWeight);
        WithSourceBranches(value.SourceBranches);
        WithIsSourceBranchFor(value.IsSourceBranchFor);
        return this;
    }

    public BranchConfiguration Build()
    {
        var result = new BranchConfiguration()
        {
            Name = name,
            VersioningMode = versioningMode,
            Label = label,
            Increment = increment,
            Regex = regex,
            TracksReleaseBranches = tracksReleaseBranches,
            TrackMergeTarget = trackMergeTarget,
            TrackMergeMessage = trackMergeMessage,
            CommitMessageIncrementing = commitMessageIncrementing,
            IsMainline = isMainline,
            IsReleaseBranch = isReleaseBranch,
            LabelNumberPattern = labelNumberPattern,
            PreventIncrementOfMergedBranchVersion = preventIncrementOfMergedBranchVersion,
            PreReleaseWeight = preReleaseWeight,
            SourceBranches = sourceBranches,
            IsSourceBranchFor = isSourceBranchFor
        };
        return result;
    }
}