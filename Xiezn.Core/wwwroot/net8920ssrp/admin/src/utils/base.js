const base = {
    get() {
        return {
            url : "http://localhost:8080/net8920ssrp/",
            name: "net8920ssrp",
            // 退出到首页链接
            indexUrl: 'http://localhost:8080/net8920ssrp/front/dist/index.html'
        };
    },
    getProjectName(){
        return {
            projectName: "在线照相机销售系统的设计与实现"
        } 
    }
}
export default base
