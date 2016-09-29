var OmPartItems = React.createClass({
    render: function () {
        var partItems = this.props.data.map(function (partitem) {
            var editClass = classNames({
                'callout': partitem.EditMode
            });
            return (
            <tbody key={partitem.Sequence}>
            <tr className="line-item {editClass}">
                <td className="col-sm-1 col-xs-2">
                    <div className="line-item-handle-container hidden-sm hidden-xs">
                        <div className="line-item-handle">
                            <DragHandle />
                        </div>
                    </div>
                    <div className="read-only">
                        <span>{partitem.PartNumber}</span>
                    </div>
                </td>
                <td className="col-sm-5 col-xs-8"><input className="form-control" type="text" value={partitem.PartName} required maxLength="500" /></td>
                <td className="col-sm-1 col-xs-1 text-center"><input className="form-control text-center" type="text" value={partitem.Quantity} required maxLength="6" /></td>
                <td className="col-sm-1 text-right hidden-xs"><input className="form-control text-right" type="text" value={partitem.PartPrice} /></td>
                <td className="col-sm-1 text-right hidden-xs"><input className="form-control text-right" type="text" value={partitem.PartLabor} required maxLength="10" /></td>
                <td className="col-sm-1 text-right hidden-xs"><input className="form-control text-right" type="text" value={partitem.PartOtherCharge} required maxLength="10" /></td>
                <td className="col-sm-1 text-right read-only"><span>{partitem.PartAndLaborSubtotal}</span></td>
                <td className="text-right"></td>
            </tr>
            </tbody>
    )
        });
return (
<table className="table table-condensed omPartItems">
{partItems}
</table>
        )

}
});

var OmPackageList = React.createClass({
    render: function () {
        var packageNodes = this.props.data.map(function (ompackage) {
            var editClass = classNames({
                'callout': ompackage.EditMode
            });
            var packageVisible = ompackage.IsPackage ? 'inline-block' : 'none';
            var packageVisibleNot = ompackage.IsPackage ? 'none' : 'inline-block';
            return (
            <div key={ompackage.PackageSequence}>
            <table className="table table-condensed package-group">
                <tbody>
                    <tr className="package-header {editClass}">
                        <td className="col-sm-6 col-xs-10">
                            <div className="package-handle-container display-inline-block">
                                <div className="package-handle">
                                    <DragHandle />
                                </div>
                            </div>
                            <div className="display-inline-block">
                                <div className="display-inline-block" style={{display: packageVisible}}>
                                <input className="form-control inline package-name" type="text" required maxLength="50" value={ompackage.PackageName} />
                                </div>
                        <div className="display-inline-block" style={{display: packageVisible}}>
                            <input className="form-control inline package-description" type="text" value={ompackage.PackageDescription} required maxLength="50" />
                        </div>
                        <div className="display-inline-block category-title" style={{display: packageVisibleNot}}>
                                    <span>{ompackage.PackageName}</span> <span>{ompackage.PackageDescription}</span>
                        </div>
                            </div>
                        </td>
                        <td className="col-sm-1 col-xs-1 text-center">
                            <input className="form-control text-center package-quantity" type="text"
style={{display: packageVisible}}
value={ompackage.PackageQuantity} required maxLength="6" />
</td>
<td className="col-sm-1 text-right hidden-xs"></td>
<td className="col-sm-1 text-right hidden-xs"></td>
<td className="col-sm-1 text-right hidden-xs"></td>
<td className="col-sm-1 col-xs-1 text-right"></td>
<td className="text-right"></td>
                    </tr>
<tr>
<td colSpan="7" className="package-items-container">
    <OmPartItems data={ompackage.PartItems}></OmPartItems>
</td>
</tr>
<tr className="package-footer">
    <td className="col-sm-6 col-xs-10"></td>
    <td className="col-sm-1 col-xs-1"></td>
    <td className="col-sm-1 text-right hidden-xs"><span>{ompackage.PackagePartSubtotal}</span></td>
    <td className="col-sm-1 text-right hidden-xs"><span>{ompackage.PackageLaborSubtotal}</span></td>
    <td className="col-sm-1 text-right hidden-xs"><span>{ompackage.PackageOtherChargeSubtotal}</span></td>
    <td className="col-sm-1 col-xs-1 text-right"><span>{ompackage.PackageTotal}</span></td>
    <td className="col-sm-1 col-xs-1 text-right"></td>
</tr>
                </tbody>
            </table>
            </div>
        );
});
return (
<div className="omPackageList">
{packageNodes}
</div>
        );
}
});

var PartsLineItems = React.createClass({
    loadData: function (e) {
        e.preventDefault();
        this.setState({ data: allData });
    },
    clearData: function (e) {
        e.preventDefault();
        this.setState({ data: [] });
    },
    getInitialState: function () {
        return { data: [] };
    },
    render: function () {
        var optionalElement;
        if (this.state.data.TicketLineItems) {
            optionalElement = (
                <div>
            <button className="btn btn-default" onClick={this.clearData }>Clear Data</button>
            <OmOPPackageList data={this.state.data.TicketLineItems } />
                </div>
            );
        } else {
            optionalElement = (
                <div>
        <button className="btn btn-default" onClick={this.loadData}>
            Load Data
        </button>
                </div>
    )
        }
        return (
        <form id="ticketlineitems-form">
            {optionalElement}
        </form>
        );
}
});
ReactDOM.render(
<PartsLineItems />,
        document.getElementById('parts-lineitems')
        );
