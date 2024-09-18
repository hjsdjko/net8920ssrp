import VueRouter from 'vue-router'

//引入组件
import Index from '../pages'
import Home from '../pages/home/home'
import Login from '../pages/login/login'
import Register from '../pages/register/register'
import Center from '../pages/center/center'
import Messages from '../pages/messages/list'
import Storeup from '../pages/storeup/list'
import AddrList from '../pages/shop-address/list'
import AddrAdd from '../pages/shop-address/addOrUpdate'
import Order from '../pages/shop-order/list'
import OrderConfirm from '../pages/shop-order/confirm'
import Cart from '../pages/shop-cart/list'
import News from '../pages/news/news-list'
import NewsDetail from '../pages/news/news-detail'
import payList from '../pages/pay'

import yonghuList from '../pages/yonghu/list'
import yonghuDetail from '../pages/yonghu/detail'
import yonghuAdd from '../pages/yonghu/add'
import xiangjileixingList from '../pages/xiangjileixing/list'
import xiangjileixingDetail from '../pages/xiangjileixing/detail'
import xiangjileixingAdd from '../pages/xiangjileixing/add'
import remaixiangjiList from '../pages/remaixiangji/list'
import remaixiangjiDetail from '../pages/remaixiangji/detail'
import remaixiangjiAdd from '../pages/remaixiangji/add'
import rukuxinxiList from '../pages/rukuxinxi/list'
import rukuxinxiDetail from '../pages/rukuxinxi/detail'
import rukuxinxiAdd from '../pages/rukuxinxi/add'
import newstypeList from '../pages/newstype/list'
import newstypeDetail from '../pages/newstype/detail'
import newstypeAdd from '../pages/newstype/add'
import systemintroList from '../pages/systemintro/list'
import systemintroDetail from '../pages/systemintro/detail'
import systemintroAdd from '../pages/systemintro/add'
import discussremaixiangjiList from '../pages/discussremaixiangji/list'
import discussremaixiangjiDetail from '../pages/discussremaixiangji/detail'
import discussremaixiangjiAdd from '../pages/discussremaixiangji/add'

const originalPush = VueRouter.prototype.push
VueRouter.prototype.push = function push(location) {
	return originalPush.call(this, location).catch(err => err)
}

//配置路由
export default new VueRouter({
	routes:[
		{
      path: '/',
      redirect: '/index/home'
    },
		{
			path: '/index',
			component: Index,
			children:[
				{
					path: 'home',
					component: Home
				},
				{
					path: 'center',
					component: Center,
				},
				{
					path: 'pay',
					component: payList,
				},
				{
					path: 'messages',
					component: Messages
				},
				{
					path: 'storeup',
					component: Storeup
				},
                {
                    path: 'shop-address/list',
                    component: AddrList
                },
                {
                    path: 'shop-address/addOrUpdate',
                    component: AddrAdd
                },
				{
					path: 'shop-order/order',
					component: Order
				},
				{
					path: 'cart',
					component: Cart
				},
				{
					path: 'shop-order/orderConfirm',
					component: OrderConfirm
				},
				{
					path: 'news',
					component: News
				},
				{
					path: 'newsDetail',
					component: NewsDetail
				},
				{
					path: 'yonghu',
					component: yonghuList
				},
				{
					path: 'yonghuDetail',
					component: yonghuDetail
				},
				{
					path: 'yonghuAdd',
					component: yonghuAdd
				},
				{
					path: 'xiangjileixing',
					component: xiangjileixingList
				},
				{
					path: 'xiangjileixingDetail',
					component: xiangjileixingDetail
				},
				{
					path: 'xiangjileixingAdd',
					component: xiangjileixingAdd
				},
				{
					path: 'remaixiangji',
					component: remaixiangjiList
				},
				{
					path: 'remaixiangjiDetail',
					component: remaixiangjiDetail
				},
				{
					path: 'remaixiangjiAdd',
					component: remaixiangjiAdd
				},
				{
					path: 'rukuxinxi',
					component: rukuxinxiList
				},
				{
					path: 'rukuxinxiDetail',
					component: rukuxinxiDetail
				},
				{
					path: 'rukuxinxiAdd',
					component: rukuxinxiAdd
				},
				{
					path: 'newstype',
					component: newstypeList
				},
				{
					path: 'newstypeDetail',
					component: newstypeDetail
				},
				{
					path: 'newstypeAdd',
					component: newstypeAdd
				},
				{
					path: 'systemintro',
					component: systemintroList
				},
				{
					path: 'systemintroDetail',
					component: systemintroDetail
				},
				{
					path: 'systemintroAdd',
					component: systemintroAdd
				},
				{
					path: 'discussremaixiangji',
					component: discussremaixiangjiList
				},
				{
					path: 'discussremaixiangjiDetail',
					component: discussremaixiangjiDetail
				},
				{
					path: 'discussremaixiangjiAdd',
					component: discussremaixiangjiAdd
				},
			]
		},
		{
			path: '/login',
			component: Login
		},
		{
			path: '/register',
			component: Register
		},
	]
})
